using SafeSpeak.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeSpeak.Services
{
    public interface IConversationService
    {
        Task<IEnumerable<Conversation>> GetAllConversationsAsync();
        Task<Conversation> GetConversationByIdAsync(int id);
        Task<IEnumerable<Conversation>> GetConversationsByUserIdAsync(int userId);
        Task CreateConversationAsync(Conversation conversation);
        Task UpdateConversationAsync(Conversation conversation);
        Task DeleteConversationAsync(Conversation conversation);
    }
}
