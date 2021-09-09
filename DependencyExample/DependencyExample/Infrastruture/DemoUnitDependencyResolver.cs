using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web;
using Unity;

namespace DependencyExample.Infrastruture
{
    public class DemoUnitDependencyResolver : IDependencyResolver

    {
        private IUnityContainer unityContainer;
        public DemoUnitDependencyResolver(IUnityContainer unityContainer) 
        {
            this.unityContainer = unityContainer;


        }
        public object GetService(Type serviceType)
        {
            try 
            {
                return unityContainer.Resolve(serviceType);

            }
            catch(Exception) 
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {

            try
            {
                return unityContainer.ResolveAll(serviceType);

            }
            catch (Exception)
            {
                return new List<object>();
            }
        }
    }
}