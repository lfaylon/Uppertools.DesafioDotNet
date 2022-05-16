using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppertools.DesafioDotNet.AccountTypes.Dto
{
    [AutoMapTo(typeof(AccountType))]
    public class UpdateAccountTypeInput : CreateAccountTypeInput, IEntityDto
    {
        public int Id { get; set; }
    }
}
