namespace SafeSpeak.API.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsEncrypted { get; set; }
        public ICollection<int> ParticipantIds { get; set; }
        public bool SessionScheduled { get; set; }
    }
}
