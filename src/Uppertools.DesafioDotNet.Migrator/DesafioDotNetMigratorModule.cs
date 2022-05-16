using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Uppertools.DesafioDotNet.Configuration;
using Uppertools.DesafioDotNet.EntityFrameworkCore;
using Uppertools.DesafioDotNet.Migrator.DependencyInjection;

namespace Uppertools.DesafioDotNet.Migrator
{
    [DependsOn(typeof(DesafioDotNetEntityFrameworkModule))]
    public class DesafioDotNetMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public DesafioDotNetMigratorModule(DesafioDotNetEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(DesafioDotNetMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                DesafioDotNetConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DesafioDotNetMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
