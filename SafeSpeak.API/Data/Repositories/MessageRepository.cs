using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SafeSpeak.API.Data;
using SafeSpeak.API.Models;
using SafeSpeak.Data.Repositories;

namespace SafeSpeak.Data.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly AppDbContext _dbContext;

        public MessageRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Message>> GetMessagesByConversationIdAsync(int conversationId)
        {
            return await _dbContext.Messages
                .Where(m => m.ConversationId == conversationId)
                .ToListAsync();
        }

        public async Task<Message> GetMessageByIdAsync(int id)
        {
            return await _dbContext.Messages.FindAsync(id);
        }

        public async Task AddMessageAsync(Message message)
        {
            _dbContext.Messages.Add(message);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateMessageAsync(Message message)
        {
            _dbContext.Messages.Update(message);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteMessageAsync(Message message)
        {
            _dbContext.Messages.Remove(message);
            await _dbContext.SaveChangesAsync();
        }

        // Implement other methods as needed
    }
}

