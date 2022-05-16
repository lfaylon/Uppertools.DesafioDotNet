using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Linq;
using Uppertools.DesafioDotNet.Authorization;
using Uppertools.DesafioDotNet.Authorization.Roles;
using Uppertools.DesafioDotNet.Authorization.Users;

namespace Uppertools.DesafioDotNet.EntityFrameworkCore.Seed.Tenants
{
    public class TenantRoleAndUserBuilder
    {
        private readonly DesafioDotNetDbContext _context;
        private readonly int _tenantId;

        public TenantRoleAndUserBuilder(DesafioDotNetDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            CreateRolesAndUsers();
        }

        private void CreateRolesAndUsers()
        {
            // Role Admin

            var adminRole = _context.Roles.IgnoreQueryFilters().FirstOrDefault(r => r.TenantId == _tenantId && r.Name == StaticRoleNames.Tenants.Admin);
            if (adminRole == null)
            {
                adminRole = _context.Roles.Add(new Role(_tenantId, StaticRoleNames.Tenants.Admin, StaticRoleNames.Tenants.Admin) { IsStatic = true }).Entity;
                _context.SaveChanges();
            }
            // Role Supplier
            var supplierRole = _context.Roles.IgnoreQueryFilters().FirstOrDefault(r => r.TenantId == _tenantId && r.Name == StaticRoleNames.Tenants.Supplier);
            if (supplierRole == null)
            {
                supplierRole = _context.Roles.Add(new Role(_tenantId, StaticRoleNames.Tenants.Supplier, StaticRoleNames.Tenants.Supplier) { IsStatic = true }).Entity;
                _context.SaveChanges();
            }


            // Permissão para Role Admin / Fornecedor

            var grantedPermissions = _context.Permissions.IgnoreQueryFilters()
                .OfType<RolePermissionSetting>()
                .Where(p => p.TenantId == _tenantId && (p.RoleId == adminRole.Id || p.RoleId == supplierRole.Id))
                .Select(p => p.Name)
                .ToList();


            var permissions = PermissionFinder
                .GetAllPermissions(new DesafioDotNetAuthorizationProvider())
                .Where(p => p.MultiTenancySides.HasFlag(MultiTenancySides.Tenant) &&
                            !grantedPermissions.Contains(p.Name))
                .ToList();

            if (permissions.Any())
            {
                _context.Permissions.AddRange(
                    permissions.Select(permission => new RolePermissionSetting
                    {
                        TenantId = _tenantId,
                        Name = permission.Name,
                        IsGranted = true,
                        RoleId = adminRole.Id
                    })
                );
                _context.SaveChanges();
            }

            // Usuário Admin user

            var adminUser = _context.Users.IgnoreQueryFilters().FirstOrDefault(u => u.TenantId == _tenantId && u.UserName == AbpUserBase.AdminUserName);
            if (adminUser == null)
            {
                adminUser = User.CreateTenantAdminUser(_tenantId, "fulano@gmail.com");
                adminUser.Password = new PasswordHasher<User>(new OptionsWrapper<PasswordHasherOptions>(new PasswordHasherOptions())).HashPassword(adminUser, "123qwe");
                adminUser.IsEmailConfirmed = true;
                adminUser.IsActive = true;

                _context.Users.Add(adminUser);
                _context.SaveChanges();

                // Assign Admin role to admin user
                _context.UserRoles.Add(new UserRole(_tenantId, adminUser.Id, adminRole.Id));
                _context.SaveChanges();
            }

            //Fornecedor

            var supplierUser = _context.Users.IgnoreQueryFilters().FirstOrDefault(u => u.TenantId == _tenantId && u.UserName == "Fornecedor");
            if (supplierUser == null)
            {
                supplierUser = User.CreateTenantSupplier(_tenantId, "fornecedor@gmail.com");
                supplierUser.Password = new PasswordHasher<User>(new OptionsWrapper<PasswordHasherOptions>(new PasswordHasherOptions())).HashPassword(supplierUser, "123qwe");
                supplierUser.IsEmailConfirmed = true;
                supplierUser.IsActive = true;

                _context.Users.Add(supplierUser);
                _context.SaveChanges();

                // Assign Admin role to admin user
                _context.UserRoles.Add(new UserRole(_tenantId, supplierUser.Id, supplierRole.Id));
                _context.SaveChanges();
            }
        }
    }
}
