using System.Web.Http;
using Unity;
using Unity.WebApi;
using Unity.Mvc5;
using QualifyMe.ServiceLayer;
using System.Web.Mvc;

namespace QualifyMe
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();


            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}