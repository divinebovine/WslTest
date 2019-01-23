using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WslTest
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Two different inconsistent behaviors can be tested by either cloning via gitbash or WSL
            // A clone via gitbash appears to work as expected, however a clone via WSL no longer works.
            // * The framework will execute code in the Global.asax.cs file unless the Global.asax and Global.asax.cs
            //   files are renamed to global.asax and global.asax.cs respectively.
            // * The ConfigurationManager WILL NOT load settings from the Web.config
            var count = ConfigurationManager.ConnectionStrings.Count;
            var name = ConfigurationManager.ConnectionStrings[0]?.Name ?? "Undefined";
            var connectionString = ConfigurationManager.ConnectionStrings[0]?.ConnectionString ?? "Undefined";

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
