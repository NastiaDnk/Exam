using ExamDB.Interfaces;
using ExamDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDB.DBOperations
{
    public class AppointmantDBOperations : IAppointmentDBOperations
    {
        private DBContext GetDBContext()
        {
            return new DBContext();
        }

        public Task<AppointmentEntity> AddAppointment(AppointmentEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAppointment(AppointmentEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<AppointmentEntity>> GetAllAppointmants()
        {
            throw new NotImplementedException();
        }

        public Task<AppointmentEntity> GetAppointmentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AppointmentEntity> UpdateAppointment(AppointmentEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
