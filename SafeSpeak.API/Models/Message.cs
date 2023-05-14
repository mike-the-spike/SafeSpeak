using System.Net.Mail;

namespace SafeSpeak.API.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int SenderId { get; set; }
        public int ConversationId { get; set; }
        public DateTime Timestamp { get; set; }
        public ICollection<Attachment> Attachments { get; set; }
    }

}
