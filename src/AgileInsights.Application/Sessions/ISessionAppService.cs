using System.Threading.Tasks;
using Abp.Application.Services;
using AgileInsights.Sessions.Dto;

namespace AgileInsights.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
