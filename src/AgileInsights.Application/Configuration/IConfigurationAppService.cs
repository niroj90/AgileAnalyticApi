using System.Threading.Tasks;
using AgileInsights.Configuration.Dto;

namespace AgileInsights.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
