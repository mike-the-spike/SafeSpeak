using SafeSpeak.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeSpeak.API.Data.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> GetUserByEmailAsync(string email);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User user);
        // Add other methods as needed
    }
}
