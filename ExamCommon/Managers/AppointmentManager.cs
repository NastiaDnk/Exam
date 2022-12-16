using AutoMapper;
using ExamCommon.Interfaces;
using ExamCommon.Models;
using ExamDB.Interfaces;
using ExamDB.Models;

namespace ExamCommon.Managers
{
    public class AppointmentManager : IAppointmentManager
    {
        private readonly IMapper _mapper;
        private readonly IAppointmentDBOperations _appointmentRepository;
        public AppointmentManager(IMapper mapper, IAppointmentDBOperations appointmentRepository)
        {
            _mapper = mapper;
            _appointmentRepository = appointmentRepository;
        }
        public async Task<Appointment> AddAppointment(Appointment appointment)
        {
            var result = await _appointmentRepository.AddAppointment(_mapper.Map<AppointmentEntity>(appointment));
            return _mapper.Map<Appointment>(result);
        }

        public async Task DeleteAppointment(Appointment appointment)
        {
            await _appointmentRepository.DeleteAppointment(_mapper.Map<AppointmentEntity>(appointment));
        }

        public async Task<List<Appointment>> GetAllAppointmants()
        {
            return (await _appointmentRepository.GetAllAppointmants())
              .Select(x => _mapper.Map<Appointment>(x)).ToList();
        }

        public async Task<Appointment> GetAppointmentByClientId(int id)
        {
            return _mapper.Map<Appointment>(await _appointmentRepository.GetAppointmentByClientId(id));
        }

        public async Task<Appointment> GetAppointmentById(int id)
        {
            return _mapper.Map<Appointment>(await _appointmentRepository.GetAppointmentById(id));
        }

        public async Task<Appointment> UpdateAppointment(Appointment appointment)
        {
            return _mapper.Map<Appointment>((await _appointmentRepository.UpdateAppointment(_mapper.Map<AppointmentEntity>(appointment))));
        }
    }
}
