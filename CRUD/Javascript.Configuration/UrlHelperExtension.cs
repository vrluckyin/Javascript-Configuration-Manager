using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Mvc
{
    public static class UrlHelperExtension
    {
        public static string Url(this UrlHelper u,string otherParts)
        {
            return string.Format("{0}{1}", u.RequestContext.HttpContext.Request.Url, otherParts);
        }
    }
}
