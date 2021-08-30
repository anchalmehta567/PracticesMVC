using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCPractice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            // Attribute Routing 
            routes.MapMvcAttributeRoutes();


            /*routes.MapRoute(
                name:"allstudents",
                url:"students",
                 new{ Controller="Routing",action= "GetAllStudent" }
                );

            // Conventional routing 
            *//*routes.MapRoute(
                name: "studentAdress",
                url: "students/Address/{id}",
                defaults: new { Controller = "Routing", action = "GetStudentAdress" }
                );
            routes.MapRoute(
               name: "students",
               url: "students/{id}",
               defaults: new { Controller = "Routing", action = "GetStudent" }
               ); *//*
          */
            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
