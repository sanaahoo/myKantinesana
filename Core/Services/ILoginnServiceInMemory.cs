using System.Collections.Concurrent;
namespace Core.Services;

public class LoginServiceInMemory : ILoginService
{
    private readonly List<(string Username, string Password)> _users = new()
    {
        ("admin", "password"),
        ("user", "1234")
    };

    public Task<bool> LoginAsync(string username, string password)
    {
        return Task.FromResult(_users.Any(user => user.Username == username && user.Password == password));
    }

    public Task<bool> ValidateUserAsync(string username, string password)
    {
        throw new NotImplementedException();
    }
}