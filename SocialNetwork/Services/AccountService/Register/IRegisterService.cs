namespace SocialNetwork.AccountService.Register
{
    public interface IRegisterService
    {
        void Register(string firstName, string lastName, string password, string email, byte gender);
    }
}