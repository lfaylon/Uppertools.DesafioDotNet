using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppertools.DesafioDotNet.AccountTypes.Dto
{
    public class GetAllAccountTypesInput : PagedAndSortedResultRequestDto
    {
        public string Description { get; set; }
    }
}
