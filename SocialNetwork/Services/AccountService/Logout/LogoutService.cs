using SocialNetwork.Services.UserService;
using System.Web.Security;

namespace SocialNetwork.AccountService.Logout
{
    public class LogoutService : ILogoutService
    {
        private IUserService _userService;

        public LogoutService(IUserService userService)
        {
            this._userService = userService;
        }

        public void Logout()
        {
            FormsAuthentication.SignOut();
        }
    }
}