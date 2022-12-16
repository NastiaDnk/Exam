using ExamCommon.Models;

namespace ExamCommon.Interfaces
{
    public interface IAppointmentManager
    {
        Task<Appointment> AddAppointment(Appointment appointment);
        Task<Appointment> UpdateAppointment(Appointment appointment);
        Task DeleteAppointment(Appointment appointment);
        Task<List<Appointment>> GetAllAppointmants();

        Task<Appointment> GetAppointmentById(int id);
        Task<Appointment> GetAppointmentByClientId(int id);
    }
}
