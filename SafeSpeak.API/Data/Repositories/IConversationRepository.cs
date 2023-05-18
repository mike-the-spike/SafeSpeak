using SafeSpeak.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeSpeak.Data.Repositories
{
    public interface IConversationRepository
    {
        Task<IEnumerable<Conversation>> GetAllConversationsAsync();
        Task<Conversation> GetConversationByIdAsync(int id);
        Task AddConversationAsync(Conversation conversation);
        Task UpdateConversationAsync(Conversation conversation);
        Task DeleteConversationAsync(Conversation conversation);
        // Add other methods as needed
    }
}
