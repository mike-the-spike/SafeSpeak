namespace SafeSpeak.API.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public DateTime Availability { get; set; }
        public User User { get; set; }
    }
}
