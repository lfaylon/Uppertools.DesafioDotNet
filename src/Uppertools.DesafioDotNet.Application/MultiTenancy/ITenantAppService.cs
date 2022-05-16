using Abp.Application.Services;
using Uppertools.DesafioDotNet.MultiTenancy.Dto;

namespace Uppertools.DesafioDotNet.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

