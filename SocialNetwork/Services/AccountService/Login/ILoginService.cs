namespace SocialNetwork.AccountService.Login
{
    public interface ILoginService
    {
        bool Login(string email, string password);
    }
}