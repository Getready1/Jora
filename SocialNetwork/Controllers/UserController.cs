using SocialNetwork.Models.EntityModels;
using SocialNetwork.Services.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocialNetwork.Controllers
{
    public class UserController : ApiController
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }
 
        [HttpPost]
        [Route("api/User/Login")]
        public User GetInfoById(int id)
        {
            return this._userService.GetById(id);
        }
    }
}
