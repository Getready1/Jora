using System;
using System.Data.Entity;

namespace SocialNetwork.DAL
{
    public interface IContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
        void Dispose();
    }
}