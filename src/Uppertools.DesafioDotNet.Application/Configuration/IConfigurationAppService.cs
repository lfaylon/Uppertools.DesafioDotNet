using System.Threading.Tasks;
using Uppertools.DesafioDotNet.Configuration.Dto;

namespace Uppertools.DesafioDotNet.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
