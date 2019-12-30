using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AgileInsights.Localization
{
    public static class AgileInsightsLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AgileInsightsConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AgileInsightsLocalizationConfigurer).GetAssembly(),
                        "AgileInsights.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
