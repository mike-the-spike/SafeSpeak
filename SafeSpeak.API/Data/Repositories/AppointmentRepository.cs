using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SafeSpeak.API.Data.Repositories;
using SafeSpeak.API.Data;
using SafeSpeak.API.Models;

namespace SafeSpeak.API.Data.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext _dbContext;

        public AppointmentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Appointment>> GetAllAppointmentsAsync()
        {
            return await _dbContext.Appointments.ToListAsync();
        }

        public async Task<Appointment> GetAppointmentByIdAsync(int id)
        {
            return await _dbContext.Appointments.FindAsync(id);
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsByUserIdAsync(int userId)
        {
            return await _dbContext.Appointments
                .Where(a => a.TherapistId == userId || a.ClientId == userId)
                .ToListAsync();
        }

        public async Task AddAppointmentAsync(Appointment appointment)
        {
            _dbContext.Appointments.Add(appointment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAppointmentAsync(Appointment appointment)
        {
            _dbContext.Appointments.Update(appointment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAppointmentAsync(Appointment appointment)
        {
            _dbContext.Appointments.Remove(appointment);
            await _dbContext.SaveChangesAsync();
        }

        // Implement other methods as needed
    }
}
