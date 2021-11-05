using System.Threading.Tasks;
using Abp.Application.Services;
using GraceTools.Authorization.Accounts.Dto;

namespace GraceTools.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
