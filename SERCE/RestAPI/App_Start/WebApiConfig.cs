using System.Web.Http;
using Microsoft.Practices.Unity.WebApi;

namespace RestAPI.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Configuración y servicios de API web
            config.DependencyResolver = new UnityDependencyResolver(UnityConfig.GetConfiguredContainer());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
