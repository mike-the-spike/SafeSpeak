using SafeSpeak.API.Data.Repositories;
using SafeSpeak.API.Models;
using SafeSpeak.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using SafeSpeak.Data.Repositories;

namespace SafeSpeak.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task<IEnumerable<Appointment>> GetAllAppointmentsAsync()
        {
            return await _appointmentRepository.GetAllAppointmentsAsync();
        }

        public async Task<Appointment> GetAppointmentByIdAsync(int id)
        {
            return await _appointmentRepository.GetAppointmentByIdAsync(id);
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsByUserIdAsync(int clientId)
        {
            return await _appointmentRepository.GetAppointmentsByUserIdAsync(clientId);
        }

        public async Task CreateAppointmentAsync(Appointment appointment)
        {
            await _appointmentRepository.AddAppointmentAsync(appointment);
        }

        public async Task UpdateAppointmentAsync(Appointment appointment)
        {
            await _appointmentRepository.UpdateAppointmentAsync(appointment);
        }

        public async Task DeleteAppointmentAsync(Appointment appointment)
        {
            await _appointmentRepository.DeleteAppointmentAsync(appointment);
        }
    }
}
