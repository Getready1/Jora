using Autofac;
using SocialNetwork.DAL;
using System;

namespace SocialNetwork.Services.UnitOfWorkService
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private IContext _context;
        bool _disposed = false;

        public UnitOfWork(ILifetimeScope scope)
        {
            this._context = scope.Resolve<IContext>();
        }

        public void SaveChanges()
        {
            if (_context != null)
                this._context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this._disposed)
                return;

            if (disposing)
            {
                if (_context != null)
                {
                    this._context.Dispose();
                }
            }

            this._disposed = true;
        }
    }
}