using Microsoft.EntityFrameworkCore;
using SafeSpeak.API.Models;
using Document = SafeSpeak.API.Models.Document;

namespace SafeSpeak.API.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        // Add DbSet properties for other entity models

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity model mappings, relationships, and other configurations
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("YourConnectionString");
            }
        }
        
    }
}
