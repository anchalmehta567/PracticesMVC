using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;

namespace MVCPractice
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           

      /*      GlobalFilters.Filters.Add(new AuthorizeAttribute());
      */      AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            UnityConfig.RegisterComponents();
            BundleConfig.RegisterBundle(BundleTable.Bundles);
          /*  GlobalFilters.Filters.Add(new HandleErrorAttribute(View="CustomError"));*/
        }
    }
}
