using Abp.Application.Services;
using Uppertools.DesafioDotNet.AccountTypes.Dto;

namespace Uppertools.DesafioDotNet.AccountTypes
{
    public interface IAccountTypeAppService : IAsyncCrudAppService<AccountTypeDto>
    {
    }
}
