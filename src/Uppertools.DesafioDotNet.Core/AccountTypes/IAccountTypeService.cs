using Abp.Domain.Services;
using System.Threading.Tasks;

namespace Uppertools.DesafioDotNet.AccountTypes
{
    public interface IAccountTypeService : IDomainService
    {
        Task<AccountType> CreateAsync(AccountType model);
        Task<AccountType> UpdateAsync(AccountType model);
        Task DeleteAsync(int id);

    }
}
