
using DoudouMons.Core.interfaces;
using DoudouMons.Infrastructure.DAL;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace DoudouMons
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IProductRepository, ProductRepository>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}