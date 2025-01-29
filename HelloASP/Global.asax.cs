using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HelloASP {
    public class Global : HttpApplication {
        void Application_Start(object sender, EventArgs e) {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Data.Settings.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        protected void Session_Start(object sender, EventArgs e) {
            if (HttpContext.Current.Session["UserVisitCount"] == null) {
                HttpContext.Current.Session["UserVisitCount"] = 1;
            }
            else {
                HttpContext.Current.Session["UserVisitCount"] = (int)HttpContext.Current.Session["UserVisitCount"] + 1;
            }
        }
    }
}