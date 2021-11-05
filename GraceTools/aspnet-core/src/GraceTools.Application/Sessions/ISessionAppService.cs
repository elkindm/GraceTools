using System.Threading.Tasks;
using Abp.Application.Services;
using GraceTools.Sessions.Dto;

namespace GraceTools.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
