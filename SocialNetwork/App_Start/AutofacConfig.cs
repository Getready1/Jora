using Autofac;
using Autofac.Integration.WebApi;
using log4net.AutoFac;
using SocialNetwork.AccountService;
using SocialNetwork.AccountService.Login;
using SocialNetwork.AccountService.Logout;
using SocialNetwork.AccountService.Register;
using SocialNetwork.DAL;
using SocialNetwork.Logging;
using SocialNetwork.Models.EntityModels;
using SocialNetwork.Services.ManagementServices;
using SocialNetwork.Services.ManagementServices.AddServices;
using SocialNetwork.Services.ManagementServices.DeleteServices;
using SocialNetwork.Services.ManagementServices.EditServices;
using SocialNetwork.Services.RepositoryService;
using SocialNetwork.Services.UnitOfWorkService;
using SocialNetwork.Services.UserService;
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

            builder.RegisterType<UserAddService>().As<IAddService<User>>();
            builder.RegisterType<UserEditService>().As<IEditService<User>>();
            builder.RegisterType<UserDeleteService>().As<IDeleteService<User>>();
            builder.RegisterGeneric(typeof(ManagementServices<>)).As(typeof(IManagementServices<>));

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            builder.RegisterType<UserService>().As<IUserService>();

            builder.RegisterType<RegisterService>().As<IRegisterService>();
            builder.RegisterType<LoginService>().As<ILoginService>();
            builder.RegisterType<LogoutService>().As<ILogoutService>();
            builder.RegisterType<Account>().As<IAccount>();
        }
    }
}