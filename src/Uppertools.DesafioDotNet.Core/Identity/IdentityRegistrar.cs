using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Uppertools.DesafioDotNet.Authorization;
using Uppertools.DesafioDotNet.Authorization.Roles;
using Uppertools.DesafioDotNet.Authorization.Users;
using Uppertools.DesafioDotNet.Editions;
using Uppertools.DesafioDotNet.MultiTenancy;

namespace Uppertools.DesafioDotNet.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
