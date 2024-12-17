using Core.Models;
using Kantineapp.Pages;

namespace Kantineserver.Repositories

{
    public interface ILoginRepository
    {
        Login? GetLogin(string username);
        public bool VerifyLogin(string username, string password);
    }
}