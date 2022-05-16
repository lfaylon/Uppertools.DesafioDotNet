using Abp.MultiTenancy;
using Uppertools.DesafioDotNet.Authorization.Users;

namespace Uppertools.DesafioDotNet.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
