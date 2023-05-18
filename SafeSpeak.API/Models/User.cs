using SafeSpeak.API.Shared.Enums;

namespace SafeSpeak.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public UserProfile Profile { get; set; }
        public List<Conversation> Conversations { get; set; }
        public List<Appointment> Appointments { get; set; }
    }

}
