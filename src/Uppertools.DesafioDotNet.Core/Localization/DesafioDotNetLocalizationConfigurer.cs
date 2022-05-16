using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Uppertools.DesafioDotNet.Localization
{
    public static class DesafioDotNetLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DesafioDotNetConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DesafioDotNetLocalizationConfigurer).GetAssembly(),
                        "Uppertools.DesafioDotNet.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
