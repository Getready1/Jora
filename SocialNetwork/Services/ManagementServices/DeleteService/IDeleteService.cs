namespace SocialNetwork.Services.ManagementServices.DeleteServices
{
    public interface IDeleteService<T> where T : class
    {
        void Delete(int? id);
    }
}