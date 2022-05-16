using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Uppertools.DesafioDotNet.EntityFrameworkCore;
using Uppertools.DesafioDotNet.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Uppertools.DesafioDotNet.Web.Tests
{
    [DependsOn(
        typeof(DesafioDotNetWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DesafioDotNetWebTestModule : AbpModule
    {
        public DesafioDotNetWebTestModule(DesafioDotNetEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DesafioDotNetWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DesafioDotNetWebMvcModule).Assembly);
        }
    }
}