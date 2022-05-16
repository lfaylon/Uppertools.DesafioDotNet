using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Uppertools.DesafioDotNet.Configuration;

namespace Uppertools.DesafioDotNet.Web.Host.Startup
{
    [DependsOn(
       typeof(DesafioDotNetWebCoreModule))]
    public class DesafioDotNetWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DesafioDotNetWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DesafioDotNetWebHostModule).GetAssembly());
        }
    }
}
