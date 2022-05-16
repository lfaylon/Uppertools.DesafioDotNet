using System.Threading.Tasks;
using Abp.Application.Services;
using Uppertools.DesafioDotNet.Authorization.Accounts.Dto;

namespace Uppertools.DesafioDotNet.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
