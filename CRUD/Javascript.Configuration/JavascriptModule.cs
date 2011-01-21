using System;
using System.Web;
using System.Web.Mvc;

namespace Javascript
{
    public class JavascriptModule : IHttpModule
    {
        /// <summary>
        /// You will need to configure this module in the web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //clean-up code here.
            System.Web.Routing.RouteTable.Routes.Clear();
        }

        public void Init(HttpApplication context)
        {
            try
            {
                System.Web.Routing.RouteTable.Routes.MapRoute(
                                    "JavascriptRoute",
                                    "Javascript/{action}",
                                    new { action = "AppSettings" },
                                    new[] { "Javascript.Configuration" }
                                );
            }
            catch
            { }
        }

        #endregion
    }
}
