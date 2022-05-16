using Abp.AutoMapper;
using Uppertools.DesafioDotNet.Authentication.External;

namespace Uppertools.DesafioDotNet.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
