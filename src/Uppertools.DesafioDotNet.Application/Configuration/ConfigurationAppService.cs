using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Uppertools.DesafioDotNet.Configuration.Dto;

namespace Uppertools.DesafioDotNet.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DesafioDotNetAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
