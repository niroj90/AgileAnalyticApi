using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AgileInsights.Controllers
{
    public abstract class AgileInsightsControllerBase: AbpController
    {
        protected AgileInsightsControllerBase()
        {
            LocalizationSourceName = AgileInsightsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
