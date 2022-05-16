using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Uppertools.DesafioDotNet.AccountTypes.Dto
{
    [AutoMapTo(typeof(AccountType))]
    public class CreateAccountTypeInput
    {
        [Required]
        [StringLength(AccountTypeConsts.MaxDescriptionLength,MinimumLength = AccountTypeConsts.MinDescriptionLength)]
        public string Description { get; set; }
    }
}
