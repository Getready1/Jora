using SocialNetwork.Services.ManagementServices.AddServices;
using SocialNetwork.Services.ManagementServices.DeleteServices;
using SocialNetwork.Services.ManagementServices.EditServices;

namespace SocialNetwork.Services.ManagementServices
{
    public interface IManagementServices<T> where T : class
    {
        IAddService<T> AddService { get; }
        IEditService<T> EditService { get; }
        IDeleteService<T> DeleteService { get; }
    }
}