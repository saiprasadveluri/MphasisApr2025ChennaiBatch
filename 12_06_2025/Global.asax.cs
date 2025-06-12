using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication12
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var ajaxBundle = new ScriptBundle("~/bundles/MsAjaxJs");
            ajaxBundle.Include("~/Scripts/MicrosoftAjax.js", "~/Scripts/MicrosoftAjaxWebForms.js");
            BundleTable.Bundles.Add(ajaxBundle);
        }

    }
}