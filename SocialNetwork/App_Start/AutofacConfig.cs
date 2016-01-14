using Autofac;
using Autofac.Integration.WebApi;
using log4net.AutoFac;
using System.Web.Http;

namespace SocialNetwork.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            var config = GlobalConfiguration.Configuration;

            RegisterTypes(builder);

            builder.RegisterApiControllers(typeof(WebApiApplication).Assembly);

            builder.RegisterModule(new LoggingModule());

            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static void RegisterTypes(ContainerBuilder builder)
        {
        }
    }
}