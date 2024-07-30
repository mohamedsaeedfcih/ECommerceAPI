using ECommerceAPI.Models;
using System.Threading.Tasks;

public interface IUserService
{
    Task<User> RegisterAsync(RegisterRequest request);
    Task<User> LoginAsync(LoginRequest request);
    Task<User> GetUserByIdAsync(int id);
}
