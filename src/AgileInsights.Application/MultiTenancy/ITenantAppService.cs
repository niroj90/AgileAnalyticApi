using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AgileInsights.MultiTenancy.Dto;

namespace AgileInsights.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

