using AutoMapper;
using ExamCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ExamDB.Models;

namespace ExamCommon.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, ClientEntity>();
            CreateMap<ClientEntity, Client>();

            CreateMap<Appointment, AppointmentEntity>();
            CreateMap<AppointmentEntity, Appointment>();
        }
    }
}
