using System.Collections.Generic;

namespace Uppertools.DesafioDotNet.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
