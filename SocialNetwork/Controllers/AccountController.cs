using SocialNetwork.AccountService;
using SocialNetwork.Models.ViewModels;
using System.Web.Http;
using System.Net.Http;

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
        public bool Login(LoginViewModel user)
        {
           return _account.Login(user);
        }

        [HttpPost]
        [Route("api/Account/Register")]
        public void Register(RegisterViewModel user)
        {
            _account.Register(user);
        }
    }
}
