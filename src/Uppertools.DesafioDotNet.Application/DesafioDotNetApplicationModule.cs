using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Uppertools.DesafioDotNet.Authorization;

namespace Uppertools.DesafioDotNet
{
    [DependsOn(
        typeof(DesafioDotNetCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DesafioDotNetApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DesafioDotNetAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DesafioDotNetApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
