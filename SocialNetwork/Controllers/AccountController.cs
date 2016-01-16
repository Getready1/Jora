using SocialNetwork.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocialNetwork.Controllers
{
    public class AccountController : ApiController
    {
        [HttpPost]
        [Route("api/Account/Login")]
        public void Login(Login user)
        {

        }

        [HttpPost]
        [Route("api/Account/Register")]
        public void Register(Register user)
        {

        }
    }
}
