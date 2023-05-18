using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SafeSpeak.API.Data;
using SafeSpeak.API.Models;
using SafeSpeak.Data.Repositories;

namespace SafeSpeak.Data.Repositories
{
    public class SessionRepository : ISessionRepository
    {
        private readonly AppDbContext _dbContext;

        public SessionRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Session>> GetSessionsByTherapistIdAsync(int therapistId)
        {
            return await _dbContext.Sessions
                .Where(s => s.TherapistId == therapistId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Session>> GetSessionsByClientIdAsync(int clientId)
        {
            return await _dbContext.Sessions
                .Where(s => s.ClientId == clientId)
                .ToListAsync();
        }

        public async Task<Session> GetSessionByIdAsync(int id)
        {
            return await _dbContext.Sessions.FindAsync(id);
        }

        public async Task AddSessionAsync(Session session)
        {
            _dbContext.Sessions.Add(session);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateSessionAsync(Session session)
        {
            _dbContext.Sessions.Update(session);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteSessionAsync(Session session)
        {
            _dbContext.Sessions.Remove(session);
            await _dbContext.SaveChangesAsync();
        }

        // Implement other methods as needed
    }
}

