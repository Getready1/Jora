using SocialNetwork.Models;
using SocialNetwork.Services.RepositoryService;

namespace SocialNetwork.Services.UnitOfWorkService
{
    public interface IUnitOfWork
    {
        IRepository<User> UserRepository { get; }
        void SaveChanges();
        void Dispose();
    }
}