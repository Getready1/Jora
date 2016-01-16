using System;
using System.Data.Entity;

namespace SocialNetwork.DAL
{
    public interface IContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
    }
}