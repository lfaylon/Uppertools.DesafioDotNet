using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;

namespace Uppertools.DesafioDotNet.AccountTypes.Dto
{
    [AutoMap(typeof(AccountType))]
    public class AccountTypeDto : EntityDto
    {
        public string Description { get; set; }

    }
}
