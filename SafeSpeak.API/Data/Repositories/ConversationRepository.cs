using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SafeSpeak.API.Data;
using SafeSpeak.API.Models;

namespace SafeSpeak.Data.Repositories
{
    public class ConversationRepository : IConversationRepository
    {
        private readonly AppDbContext _dbContext;

        public ConversationRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Conversation>> GetAllConversationsAsync()
        {
            return await _dbContext.Conversations
                .Include(c => c.Users)
                .Include(c => c.Messages)
                .Include(c => c.Documents)
                .ToListAsync();
        }

        public async Task<Conversation> GetConversationByIdAsync(int id)
        {
            return await _dbContext.Conversations
                .Include(c => c.Users)
                .Include(c => c.Messages)
                .Include(c => c.Documents)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddConversationAsync(Conversation conversation)
        {
            _dbContext.Conversations.Add(conversation);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateConversationAsync(Conversation conversation)
        {
            _dbContext.Conversations.Update(conversation);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteConversationAsync(Conversation conversation)
        {
            _dbContext.Conversations.Remove(conversation);
            await _dbContext.SaveChangesAsync();
        }

        // Implement other methods as needed
    }
}

