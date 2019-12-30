using System.Threading.Tasks;
using Abp.Application.Services;
using AgileInsights.Authorization.Accounts.Dto;

namespace AgileInsights.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
