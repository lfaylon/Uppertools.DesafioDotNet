using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uppertools.DesafioDotNet.AccountTypes.Dto;
using Uppertools.DesafioDotNet.Authorization;

namespace Uppertools.DesafioDotNet.AccountTypes
{
    [AbpAuthorize(PermissionNames.Pages_AccountTypes)]
    public class AccountTypeAppService : AsyncCrudAppService<AccountType, AccountTypeDto, int, GetAllAccountTypesInput, CreateAccountTypeInput, UpdateAccountTypeInput>, IAccountTypeAppService
    {
        private readonly IRepository<AccountType> _repository;
        private readonly IAccountTypeService _accountTypeService;

        public AccountTypeAppService(IRepository<AccountType> repository, IAccountTypeService accountTypeService) : base(repository)
        {
            _repository = repository;
            _accountTypeService = accountTypeService;
        }

        public Task<AccountTypeDto> CreateAsync(AccountTypeDto input)
        {
            throw new System.NotImplementedException();
        }

        public Task<PagedResultDto<AccountTypeDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            throw new System.NotImplementedException();
        }

        public Task<AccountTypeDto> UpdateAsync(AccountTypeDto input)
        {
            throw new System.NotImplementedException();
        }

        ////public async Task<PagedResultDto<AccountTypeDto>> GetAllAsync(GetAllAccountTypesInput input)
        ////{
        ////    this.get
        ////    var filteredAccountTypes = _repository.GetAll().WhereIf(!string.IsNullOrWhiteSpace(input.Description), e => false || e.Description.Contains(input.Description)).AsEnumerable();

        ////    var pagedAndFilteredAccountTypes = filteredAccountTypes
        ////        //.OrderBy(input.Sorting ?? "id asc")
        ////        //.PageBy(input)
        ////        ;

        ////    var accountTypes = from o in pagedAndFilteredAccountTypes
        ////                       select new
        ////                       {
        ////                           o.Description,
        ////                           Id = o.Id
        ////                       };

        ////    var totalCount = filteredAccountTypes.Count();

        ////    var dbList = accountTypes.ToList();
        ////    var results = new List<AccountTypeDto>();

        ////    foreach (var o in dbList)
        ////    {
        ////        var res = new AccountTypeDto()
        ////        {
        ////            Description = o.Description,
        ////            Id = o.Id,
        ////        };

        ////        results.Add(res);
        ////    }
        ////    return new PagedResultDto<AccountTypeDto>(
        ////        totalCount,
        ////        results
        ////    );
        ////}


        //public async Task<AccountTypeDto> CreateAsync(AccountTypeDto input)
        //{
        //    var accountType = ObjectMapper.Map<AccountType>(input);

        //    await _accountTypeService.CreateAsync(accountType);

        //    return ObjectMapper.Map<AccountTypeDto>(accountType);
        //}

        //public Task<PagedResultDto<AccountTypeDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        //{
        //    return this.GetAllAsync(input);
        //}

        //public async Task<AccountTypeDto> UpdateAsync(AccountTypeDto input)
        //{
        //    var accountType = ObjectMapper.Map<AccountType>(input);

        //    await _accountTypeService.UpdateAsync(accountType);

        //    return ObjectMapper.Map<AccountTypeDto>(accountType);
        //}

        ////public override async Task DeleteAsync(EntityDto<int> input)
        ////{
        ////    var user = await this.GetByIdAsync(input.Id);
        ////    await this.DeleteAsync(user);
        ////}





        protected override IQueryable<AccountType> CreateFilteredQuery(GetAllAccountTypesInput input)
        {
            return base.CreateFilteredQuery(input).WhereIf(!string.IsNullOrEmpty(input.Description), t => t.Description == input.Description).AsQueryable();
        }
    }
}
