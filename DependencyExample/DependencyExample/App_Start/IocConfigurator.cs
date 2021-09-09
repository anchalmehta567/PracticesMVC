using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyExample.Services;
using Unity;
using Unity.Mvc5;
using DependencyExample.Infrastruture;
namespace DependencyExample.App_Start
{
    public static class IocConfigurator
    {
        public static void ConfigureIocUnityContainer() 
        {
            IUnityContainer container = new UnityContainer();
            registerServices(container);
            DependencyResolver.SetResolver(new DemoUnitDependencyResolver(container));

        }

        private static void registerServices(IUnityContainer container)
        {
            container.RegisterType<IlocalWeatherServices, localWeatherServices>();
        }
    }
}