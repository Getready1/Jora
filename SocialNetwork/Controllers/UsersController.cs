using SocialNetwork.Services.UnitOfWorkService;
using System.Collections.Generic;
using System.Web.Http;

namespace SocialNetwork.Controllers
{
    public class UsersController : ApiController
    {
        private IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        // GET: api/Users
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}