using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SafeSpeak.API.Data;
using SafeSpeak.API.Data.Repositories;
using SafeSpeak.Data.Repositories;
using SafeSpeak.Services;
using SafeSpeak.API.Services;

namespace SafeSpeak
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configure services
            services.AddControllers();
            services.AddSwaggerGen();

            // Configure the database context
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("YourConnectionString")));

            // Register repositories as needed
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IConversationRepository, ConversationRepository>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            services.AddScoped<IUserProfileRepository, UserProfileRepository>();

            // Register services for dependency injection
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<IConversationService,ConversationService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IUserService, UserService>();


        }

        public void Configure(IApplicationBuilder app)
        {
            // Configure middleware pipeline
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
