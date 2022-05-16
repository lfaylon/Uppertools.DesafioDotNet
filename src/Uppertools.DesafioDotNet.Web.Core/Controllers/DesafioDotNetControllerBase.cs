using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Uppertools.DesafioDotNet.Controllers
{
    public abstract class DesafioDotNetControllerBase: AbpController
    {
        protected DesafioDotNetControllerBase()
        {
            LocalizationSourceName = DesafioDotNetConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
