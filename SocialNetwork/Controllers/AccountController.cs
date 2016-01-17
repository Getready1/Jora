using SocialNetwork.AccountService;
using SocialNetwork.Models.ViewModels;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

        [HttpGet]
        [Route("api/Account/Login")]
        public bool Login(LoginViewModel user)
        {
            return _account.Login(user);
        }

        [HttpPost]
        [Route("api/Account/Register")]
        public void Register(RegisterViewModel user)
        {
            string sessionId = "";

            CookieHeaderValue cookie = Request.Headers.GetCookies("session-id").FirstOrDefault();
            if (cookie != null)
            {
                sessionId = cookie["session-id"].Value;
            }

            //_account.Register(user);
        }
    }
}
