using System.Web.Http;
using Unity;
using Unity.WebApi;
using Common.Interfaces.Repositories;
using WebAPI.Repositories;

namespace WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IProductRepo, ProductRepo>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}