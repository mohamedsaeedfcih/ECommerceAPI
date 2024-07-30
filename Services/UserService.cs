using ECommerceAPI.Models;
using ECommerceAPI.Repositories;
using System.Threading.Tasks;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> RegisterAsync(RegisterRequest request)
    {
        var user = new User
        {
            Username = request.Username,
            Password = request.Password,
            Email = request.Email
        };

        await _userRepository.AddUserAsync(user);
        return user;
    }

    public async Task<User> LoginAsync(LoginRequest request)
    {
        var user = await _userRepository.GetUserByUsernameAsync(request.Username);
        if (user != null && user.Password == request.Password)
        {
            return user;
        }

        return null;
    }

    public async Task<User> GetUserByIdAsync(int id)
    {
        return await _userRepository.GetUserByIdAsync(id);
    }
}
