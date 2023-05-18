using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SafeSpeak.API.Data;
using SafeSpeak.API.Models;
using SafeSpeak.Data.Repositories;

namespace SafeSpeak.API.Data.Repositories
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly AppDbContext _dbContext;

        public UserProfileRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserProfile> GetUserProfileByIdAsync(int id)
        {
            return await _dbContext.UserProfiles.FindAsync(id);
        }

        public async Task<UserProfile> GetUserProfileByUserIdAsync(int userId)
        {
            return await _dbContext.UserProfiles
                .FirstOrDefaultAsync(up => up.UserId == userId);
        }

        public async Task AddUserProfileAsync(UserProfile userProfile)
        {
            _dbContext.UserProfiles.Add(userProfile);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUserProfileAsync(UserProfile userProfile)
        {
            _dbContext.UserProfiles.Update(userProfile);
            await _dbContext.SaveChangesAsync();
        }

        // Implement other methods as needed
    }
}
