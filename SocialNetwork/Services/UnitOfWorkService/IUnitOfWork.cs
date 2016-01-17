using SocialNetwork.Models;
using SocialNetwork.Models.EntityModels;
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