using SafeSpeak.API.Models;
using SafeSpeak.Data.Repositories;
using SafeSpeak.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeSpeak.API.Services
{
    public class ConversationService : IConversationService
    {
        private readonly IConversationRepository _conversationRepository;

        public ConversationService(IConversationRepository conversationRepository)
        {
            _conversationRepository = conversationRepository;
        }

        public Task<IEnumerable<Conversation>> GetAllConversationsAsync()
        {
            return _conversationRepository.GetAllConversationsAsync();
        }

        public Task<Conversation> GetConversationByIdAsync(int id)
        {
            return _conversationRepository.GetConversationByIdAsync(id);
        }

        public Task AddConversationAsync(Conversation conversation)
        {
            return _conversationRepository.AddConversationAsync(conversation);
        }

        public Task UpdateConversationAsync(Conversation conversation)
        {
            return _conversationRepository.UpdateConversationAsync(conversation);
        }

        public Task DeleteConversationAsync(Conversation conversation)
        {
            return _conversationRepository.DeleteConversationAsync(conversation);
        }
        // Implement other methods as needed
    }
}
