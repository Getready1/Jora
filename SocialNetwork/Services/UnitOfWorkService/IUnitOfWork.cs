namespace SocialNetwork.Services.UnitOfWorkService
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        void Dispose();
    }
}