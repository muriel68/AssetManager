using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using RandaAssetManager.App_Start;

namespace RandaAssetManager
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzAyMzFAMzEzNjJlMzMyZTMwZm1Ob3ZGZ0tvbHVyU3lVZmJvaTZPVVVzaUpLV3g2ejg1TWQxakRDZlV2Yz0=");

            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void Application_Error(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();
            Server.ClearError();
        }
    }
}
