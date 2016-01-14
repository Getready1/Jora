using Autofac;
using Autofac.Integration.WebApi;
using log4net.AutoFac;
using SocialNetwork.DAL;
using SocialNetwork.Logging;
using SocialNetwork.Services.RepositoryService;
using SocialNetwork.Services.UnitOfWorkService;
using System.Web.Http;

namespace SocialNetwork
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
            builder.RegisterType<Context>().As<IContext>();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<Log4NetLoggingAdapter>().As<ILogger>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}