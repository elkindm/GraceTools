using Abp.Application.Services;
using GraceTools.MultiTenancy.Dto;

namespace GraceTools.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

