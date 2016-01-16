using System.Web.Http;

namespace SocialNetwork
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "MainPage",
                routeTemplate: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" },
                constraints: new { controller = "Home", action = "Index" }
            );
        }
    }
}