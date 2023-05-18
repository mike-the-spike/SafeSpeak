using SafeSpeak.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeSpeak.Data.Repositories
{
    public interface IDocumentRepository
    {
        Task<Document> GetDocumentByIdAsync(int id);
        Task<IEnumerable<Document>> GetDocumentsByConversationIdAsync(int conversationId);
        Task AddDocumentAsync(Document document);
        Task UpdateDocumentAsync(Document document);
        Task DeleteDocumentAsync(Document document);
        // Add other methods as needed
    }
}
