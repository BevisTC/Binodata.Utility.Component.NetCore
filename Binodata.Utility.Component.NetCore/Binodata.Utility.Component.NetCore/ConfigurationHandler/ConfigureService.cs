using System.Collections.Specialized;
using System.Configuration;

namespace Binodata.Utility.Component.NetCore.ConfigurationHandler
{
    public class ConfigureService : IConfigureService
    {
        private NameValueCollection GetApplicationSettings()
        {
            var applicationSettings = ConfigurationManager.GetSection("appSettings") as NameValueCollection;
            return applicationSettings;
        }

        public string GetConfigByKey(string key)
        {
            NameValueCollection collection = GetApplicationSettings();
            return collection[key];
        }
    }
}
