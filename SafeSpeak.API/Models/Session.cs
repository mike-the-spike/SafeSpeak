namespace SafeSpeak.API.Models
{
    public class Session
    {
        public int Id { get; set; }
        public int TherapistId { get; set; }
        public int ClientId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Transcription { get; set; }
    }

}
