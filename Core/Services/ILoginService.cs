using Core.Model;

namespace MyKantine.Services
{
    public interface ILoginService
    {
        Task<bool> VerifyLogin(string username, string password);
        Task<Login> GetLogin(string username);


    }
}