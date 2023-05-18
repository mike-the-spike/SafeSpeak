namespace SafeSpeak.API.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<User> Users { get; set; }
        public List<Message> Messages { get; set; }
        public List<Document> Documents { get; set; }
    }
}
