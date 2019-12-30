using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AgileInsights.Authorization;

namespace AgileInsights
{
    [DependsOn(
        typeof(AgileInsightsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AgileInsightsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AgileInsightsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AgileInsightsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
