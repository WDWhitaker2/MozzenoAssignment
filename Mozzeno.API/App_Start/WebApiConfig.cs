using Mozzeno.Contracts.Data;
using Mozzeno.Data.Repositories;
using System.Web.Http;
using Unity.Lifetime;
using Unity;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Headers;
using Mozzeno.API.ExceptionFilter;

namespace Mozzeno.Assessment
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // forces response to return as json by default
            config.Formatters.JsonFormatter.SupportedMediaTypes
                .Add(new MediaTypeHeaderValue("text/html"));

            // forced json converter to use snake case.
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
                new DefaultContractResolver { NamingStrategy = new SnakeCaseNamingStrategy() };
            
            // adds custon formatting
            config.Filters.Add(new CustomExceptionFilter());


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
