using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SafeSpeak.API.Data;
using SafeSpeak.API.Models;
using SafeSpeak.Data.Repositories;

namespace SafeSpeak.Data.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly AppDbContext _dbContext;

        public DocumentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Document> GetDocumentByIdAsync(int id)
        {
            return await _dbContext.Documents.FindAsync(id);
        }

        public async Task<IEnumerable<Document>> GetDocumentsByConversationIdAsync(int conversationId)
        {
            return await _dbContext.Documents
                .Where(d => d.ConversationId == conversationId)
                .ToListAsync();
        }

        public async Task AddDocumentAsync(Document document)
        {
            _dbContext.Documents.Add(document);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateDocumentAsync(Document document)
        {
            _dbContext.Documents.Update(document);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteDocumentAsync(Document document)
        {
            _dbContext.Documents.Remove(document);
            await _dbContext.SaveChangesAsync();
        }

        // Implement other methods as needed
    }
}
