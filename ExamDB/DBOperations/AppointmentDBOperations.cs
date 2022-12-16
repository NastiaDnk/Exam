using ExamDB.Interfaces;
using ExamDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDB.DBOperations
{
    public class AppointmentDBOperations : IAppointmentDBOperations
    {
        private DBContext GetDBContext()
        {
            return new DBContext();
        }

        public async Task<AppointmentEntity> AddAppointment(AppointmentEntity entity)
        {
            using (DBContext dbContext = GetDBContext())
            {
                dbContext.Appointment.Add(entity);
                await dbContext.SaveChangesAsync();
                return entity;
            }
        }

        public Task DeleteAppointment(AppointmentEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AppointmentEntity>> GetAllAppointmants()
        {
            using (DBContext dbContext = GetDBContext())
            {
                return dbContext.Appointment.ToList();
            }
        }

        public async Task<AppointmentEntity> GetAppointmentById(int id)
        {
            using (DBContext dbContext = GetDBContext())
            {
                return dbContext.Appointment.First(ap => ap.Id == id);
            }
        }

        public async Task<AppointmentEntity> GetAppointmentByClientId(int id)
        {
            using (DBContext dbContext = GetDBContext())
            {
                return dbContext.Appointment.First(ap => ap.ClientID == id);
            }
        }

        public async Task<AppointmentEntity> UpdateAppointment(AppointmentEntity entity)
        {
            using (DBContext dbContext = GetDBContext())
            {
                dbContext.Appointment.Update(entity);
                await dbContext.SaveChangesAsync();
                return entity;
            }
        }
    }
}
