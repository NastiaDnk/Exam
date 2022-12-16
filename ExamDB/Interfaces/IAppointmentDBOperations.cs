using ExamDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDB.Interfaces
{
    public interface IAppointmentDBOperations
    {
        Task<AppointmentEntity> AddAppointment(AppointmentEntity entity);
        Task<AppointmentEntity> UpdateAppointment(AppointmentEntity entity);
        Task DeleteAppointment(AppointmentEntity entity);
        Task<List<AppointmentEntity>> GetAllAppointmants();

        Task<AppointmentEntity> GetAppointmentById(int id);
    }
}
