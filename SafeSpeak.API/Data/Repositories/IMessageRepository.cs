using SafeSpeak.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeSpeak.Data.Repositories
{
    public interface IMessageRepository
    {
        Task<IEnumerable<Message>> GetMessagesByConversationIdAsync(int conversationId);
        Task<Message> GetMessageByIdAsync(int id);
        Task AddMessageAsync(Message message);
        Task UpdateMessageAsync(Message message);
        Task DeleteMessageAsync(Message message);
        // Add other methods as needed
    }
}

