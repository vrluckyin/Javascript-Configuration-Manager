using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.IO;

namespace Javascript.Configuration
{
    public class JavascriptController : Controller
    {
        public FileStreamResult AppSettings()
        {
            string keys = System.Configuration.ConfigurationManager.AppSettings["jsConfig"];
            string js = ConfigurationManager.AppSettings(keys);
            MemoryStream ms = new MemoryStream(System.Text.ASCIIEncoding.ASCII.GetBytes(js), true);
            return new FileStreamResult(ms, "text/plain");
        }
        public FileStreamResult DbSettings()
        {
            return null;
        }
        public FileStreamResult Image()
        {
            return null;
        }
    }
}
