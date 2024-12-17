using Core.Models; 
using System.Collections.Generic;
using System.Threading.Tasks;
using Kantineapp.Core.Models;
using Kantineapp.Pages;

namespace Kantinneserver.Repositories
{
    public interface ILoginRepository
    {
        public Task<Login> CreateAsync(Login newLogin);
        Task<IEnumerable<Login>> GetAllAsync();
       
        
    }
}
