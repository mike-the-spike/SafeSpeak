using SafeSpeak.API.Models;
using System.Threading.Tasks;

namespace SafeSpeak.Data.Repositories
{
    public interface IUserProfileRepository
    {
        Task<UserProfile> GetUserProfileByIdAsync(int id);
        Task<UserProfile> GetUserProfileByUserIdAsync(int userId);
        Task AddUserProfileAsync(UserProfile userProfile);
        Task UpdateUserProfileAsync(UserProfile userProfile);
        // Add other methods as needed
    }
}
