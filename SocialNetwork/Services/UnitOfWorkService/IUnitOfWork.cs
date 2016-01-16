using SocialNetwork.Models;
using SocialNetwork.Services.RepositoryService;
using System;

namespace SocialNetwork.Services.UnitOfWorkService
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> UserRepository { get; }
        void SaveChanges();
    }
}