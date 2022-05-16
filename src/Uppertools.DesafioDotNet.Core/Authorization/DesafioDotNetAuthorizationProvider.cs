using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Uppertools.DesafioDotNet.Authorization
{
    public class DesafioDotNetAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"));
            context.CreatePermission(PermissionNames.Pages_HangfireDashboard, L("Hangfire"));
            context.CreatePermission(PermissionNames.Pages_Suppliers, L("Suppliers"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_AccountTypes, L("CostCenters"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Expenses, L("Expenses"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, DesafioDotNetConsts.LocalizationSourceName);
        }
    }
}
