using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppertools.DesafioDotNet.AccountTypes
{
    public class AccountTypeService : DomainService, IAccountTypeService
    {

        private readonly IRepository<AccountType,int> _repository;

        public AccountTypeService(IRepository<AccountType, int> repository)
        {
            _repository = repository;
        }
        public async Task<AccountType> CreateAsync(AccountType model)
        {
            throw new NotImplementedException();
        }
        public async Task<AccountType> UpdateAsync(AccountType model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
