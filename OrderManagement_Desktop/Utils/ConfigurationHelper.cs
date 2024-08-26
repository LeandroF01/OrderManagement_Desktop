using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Utils
{
    internal class ConfigurationHelper
    {
        public static string GetTokenFromConfig()
        {
            return ConfigurationManager.AppSettings["AuthToken"];
        }

        public static void SaveTokenToConfig(string token)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["AuthToken"].Value = token;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
