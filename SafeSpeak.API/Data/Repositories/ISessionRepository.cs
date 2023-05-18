using SafeSpeak.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeSpeak.Data.Repositories
{
    public interface ISessionRepository
    {
        Task<IEnumerable<Session>> GetSessionsByTherapistIdAsync(int therapistId);
        Task<IEnumerable<Session>> GetSessionsByClientIdAsync(int clientId);
        Task<Session> GetSessionByIdAsync(int id);
        Task AddSessionAsync(Session session);
        Task UpdateSessionAsync(Session session);
        Task DeleteSessionAsync(Session session);
        // Add other methods as needed
    }
}
