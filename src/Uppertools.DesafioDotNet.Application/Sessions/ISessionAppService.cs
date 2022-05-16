using System.Threading.Tasks;
using Abp.Application.Services;
using Uppertools.DesafioDotNet.Sessions.Dto;

namespace Uppertools.DesafioDotNet.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
