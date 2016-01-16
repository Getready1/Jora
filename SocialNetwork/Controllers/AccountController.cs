using SocialNetwork.AccountService;
using SocialNetwork.Models.ViewModels;
using System.Web.Http;

namespace SocialNetwork.Controllers
{
    public class AccountController : ApiController
    {
        private IAccount _account;

        public AccountController(IAccount account)
        {
            this._account = account;
        }

        [HttpPost]
        [Route("api/Account/Login")]
        public void Login(LoginViewModel user)
        {

        }

        [HttpPost]
        [Route("api/Account/Register")]
        public void Register(RegisterViewModel user)
        {
            _account.Register(user);
        }
    }
}
