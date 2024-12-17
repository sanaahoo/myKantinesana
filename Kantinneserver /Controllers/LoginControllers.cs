using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MyKantine.Repositories;
using MyKantine.Models;
namespace ThriftShopAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private IUserRepo _userRepo;
        public LoginController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        [HttpPost]

        public async Task<Usernname> Login(UserAuthentication ua)
        {
            
            var user = await _userRepo.GetUser(ua.Email.ToLower());
            if (user == null)
            {
                return null;
            }
            if (user.Password == ua.Password)
            {
                return user;
            }
            return null;
        }
    }
}
