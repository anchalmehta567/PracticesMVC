using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using MVCPractice.Models;
using MVCPractice.Controllers;
using BL;
namespace MVCPractice
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

          container.RegisterType<IEmployeeData,EmployeeData>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}