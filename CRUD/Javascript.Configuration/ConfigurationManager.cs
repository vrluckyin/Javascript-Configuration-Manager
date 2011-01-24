using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
namespace Javascript.Configuration
{
    public class ConfigurationManager
    {
        public static string AppSettings(string keys)
        {

            string[] aKeys =keys==null?null:keys.ToLower().Split(',');
            StringBuilder js = new StringBuilder();
            // js.AppendLine("<script>");
            js.AppendLine("var Javascript = Javascript||{};");
            js.AppendLine("Javascript.Configuration = Javascript.Configuration||{};");
            js.AppendLine("Javascript.Configuration.ConfigurationManager = Javascript.Configuration.ConfigurationManager||{};");
            js.AppendLine("var appSettings = new Array();");
            if (aKeys!=null)
            {
                for (int i = 0; i < System.Configuration.ConfigurationManager.AppSettings.Keys.Count; i++)
                {
                    string key = System.Configuration.ConfigurationManager.AppSettings.Keys[i];
                    if (aKeys.Contains(key.ToLower()) || (aKeys.Count() == 1 && aKeys[0] == "all"))
                    {
                        string value = System.Configuration.ConfigurationManager.AppSettings[key];
                        js.AppendLine(String.Format("appSettings.{0}=\"{1}\";", key, value));
                    }
                }
            }
            js.AppendLine("Javascript.Configuration.ConfigurationManager.AppSettings = appSettings;");
            //js.AppendLine("</script>");
            return js.ToString();
        }
    }
}
