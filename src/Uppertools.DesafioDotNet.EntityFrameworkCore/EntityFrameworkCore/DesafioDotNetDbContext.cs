using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Uppertools.DesafioDotNet.AccountTypes;
using Uppertools.DesafioDotNet.Authorization.Roles;
using Uppertools.DesafioDotNet.Authorization.Users;
using Uppertools.DesafioDotNet.CostCenters;
using Uppertools.DesafioDotNet.MultiTenancy;

namespace Uppertools.DesafioDotNet.EntityFrameworkCore
{
    public class DesafioDotNetDbContext : AbpZeroDbContext<Tenant, Role, User, DesafioDotNetDbContext>
    {
        public DbSet<CostCenter> CostCenters { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }

        public DesafioDotNetDbContext(DbContextOptions<DesafioDotNetDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Customizações do Modelo
            base.OnModelCreating(modelBuilder);
        }
    }
}
