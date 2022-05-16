using Abp.Application.Services.Dto;

namespace Uppertools.DesafioDotNet.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

