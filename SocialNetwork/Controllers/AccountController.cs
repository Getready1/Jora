using SocialNetwork.AccountService;
using SocialNetwork.Models.ViewModels;
using System.Net;
using System.Net.Http;
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
        public HttpResponseMessage Login(LoginViewModel user)
        {
           if(_account.Login(user))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
           else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [HttpPost]
        [Route("api/Account/Register")]
        public void Register(RegisterViewModel user)
        {
            _account.Register(user);
        }
    }
}