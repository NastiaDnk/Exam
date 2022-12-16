using AutoMapper;
using ExamCommon.Interfaces;
using ExamCommon.Models;
using ExamDB.Interfaces;
using ExamDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentManager _appointmentManager;
        public AppointmentController(IAppointmentManager appointmentManager)
        {
            _appointmentManager = appointmentManager;
        }
        [HttpGet]
        public async Task<IActionResult> Appointments()
        {
            try
            {
                return Ok(await _appointmentManager.GetAllAppointmants());
            }
            catch (System.Exception ex)
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddNewAppointment(Appointment appointment)
        {
            try
            {
                return Ok(_appointmentManager.AddAppointment(appointment));
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update(Appointment appointment)
        {
            try
            {
                return Ok(_appointmentManager.UpdateAppointment(appointment));
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Remove(Appointment appointment)
        {
            try
            {
                return Ok(_appointmentManager.DeleteAppointment(appointment));
            }
            catch (System.Exception ex)
            {
                return NotFound();
            }
        }
    }
}
