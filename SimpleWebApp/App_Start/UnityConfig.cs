using SimpleWebApp.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace SimpleWebApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IMvcWebProjectEntities2, MvcWebProjectEntities2>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}