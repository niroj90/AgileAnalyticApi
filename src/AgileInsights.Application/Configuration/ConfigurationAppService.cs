using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AgileInsights.Configuration.Dto;

namespace AgileInsights.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AgileInsightsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
