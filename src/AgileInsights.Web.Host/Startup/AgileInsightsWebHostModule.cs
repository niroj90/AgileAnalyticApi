using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AgileInsights.Configuration;

namespace AgileInsights.Web.Host.Startup
{
    [DependsOn(
       typeof(AgileInsightsWebCoreModule))]
    public class AgileInsightsWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AgileInsightsWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AgileInsightsWebHostModule).GetAssembly());
        }
    }
}
