using SocialNetwork.Logging;
using SocialNetwork.Models;
using SocialNetwork.Models.EntityModels;

namespace SocialNetwork.Services.ManagementServices.DeleteServices
{
    public class UserDeleteService : IDeleteService<User>
    {
        private ILogger _log;

        public UserDeleteService(ILogger log)
        {
            this._log = log;
        }

        public void Delete(int? id)
        {
            if (id == null)
                return;
        }
    }
}