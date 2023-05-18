namespace SafeSpeak.API.Models
{
    public class Document
    {
        public int Id { get; set; }
        public int ConversationId { get; set; }
        public int UploaderId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadedAt { get; set; }
        public User Uploader { get; set; }
        public Conversation Conversation { get; set; }
    }
}
