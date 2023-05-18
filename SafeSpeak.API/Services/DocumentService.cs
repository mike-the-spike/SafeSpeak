using SafeSpeak.API.Models;
using SafeSpeak.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeSpeak.API.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentService(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public Task<Document> GetDocumentByIdAsync(int id)
        {
            return _documentRepository.GetDocumentByIdAsync(id);
        }

        public Task<IEnumerable<Document>> GetDocumentsByConversationIdAsync(int conversationId)
        {
            return _documentRepository.GetDocumentsByConversationIdAsync(conversationId);
        }

        public Task AddDocumentAsync(Document document)
        {
            return _documentRepository.AddDocumentAsync(document);
        }

        public Task UpdateDocumentAsync(Document document)
        {
            return _documentRepository.UpdateDocumentAsync(document);
        }

        public Task DeleteDocumentAsync(Document document)
        {
            return _documentRepository.DeleteDocumentAsync(document);
        }
        // Implement other methods as needed
    }
}
