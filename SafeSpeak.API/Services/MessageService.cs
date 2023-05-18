using SafeSpeak.API.Models;
using SafeSpeak.Data.Repositories;
using SafeSpeak.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeSpeak.API.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public Task<IEnumerable<Message>> GetMessagesByConversationIdAsync(int conversationId)
        {
            return _messageRepository.GetMessagesByConversationIdAsync(conversationId);
        }

        public Task<Message> GetMessageByIdAsync(int id)
        {
            return _messageRepository.GetMessageByIdAsync(id);
        }

        public Task AddMessageAsync(Message message)
        {
            return _messageRepository.AddMessageAsync(message);
        }

        public Task UpdateMessageAsync(Message message)
        {
            return _messageRepository.UpdateMessageAsync(message);
        }

        public Task DeleteMessageAsync(Message message)
        {
            return _messageRepository.DeleteMessageAsync(message);
        }
        // Implement other methods as needed
    }
}
