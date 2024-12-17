using Kantineapp.Pages;
using Kantinneserver.Repositories;

namespace Kantinneserver.Repositories
{
    public class LoginRepository : ILoginRepository 
    {
        private readonly List<Login> _users = new();
        private string connectionString = "mongodb+srv://sanaa2104:9xRHv28k5gLVqjL5@cluster0.uvwry.mongodb.net/";

   
        IMongoClient mongoClient;

        IMongoDatabase database;

        IMongoCollection<Login> collection;
        public LoginRepository()
        {
            //var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            //   string connectionString = config["ConnectionStrings:MyConnectionString"];



            mongoClient = new MongoClient(connectionString);

            

            database = mongoClient.GetDatabase("kantinedb");

            collection = database.GetCollection<Login>("login_collection");
        }

        /*public LoginRepository(string? s, string yourdatabasename, string login)
        {
            throw new NotImplementedException();
        }
*/
        public Task<IEnumerable<Login>> GetAllAsync()
        {
            throw new NotImplementedException();
        }


        public Task<Login> CheckLogin(string Username)
        {
            foreach (var login in GetAllAsync())
            {
            }



            _
        }

        public Task<bool> UpdateAsync(Login login)
        {
            var existingUser = _users.FirstOrDefault(u => u.Id == login.Id);
            if (existingUser != null)
            {
                existingUser.Navn = login.Navn;
                existingUser.Email = login.Email;
                return Task.FromResult(true);
            }

            return Task.FromResult(false);


        }
