using DigitalClinic.Server.Repository;
using DigitalClinic.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DigitalClinic.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentController(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        // GET: api/<AppointmentController>
        [HttpGet]
        public IActionResult GetAllAppointments ()
        {
            return Ok(_appointmentRepository.GetAllAppointments());
        }

        [HttpGet("{id}")]
        public IActionResult GetAppointmentById(int id)
        {
            return Ok(_appointmentRepository.GetAppointmentById(id));
        }

        [HttpPost]
        public IActionResult CreateAppointment([FromBody] Appointment appointment)
        {
            if (appointment == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var createdDoctor = _appointmentRepository.AddAppointment(appointment);

            return Created("appointment", createdDoctor);
        }

        [HttpPut]
        public IActionResult UpdateAppointment([FromBody] Appointment appointment)
        {
            if (appointment == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var doctorToUpdate = _appointmentRepository.GetAppointmentById(appointment.Id);
            if (doctorToUpdate == null)
                return NotFound();

            _appointmentRepository.UpdateAppointment(appointment);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAppointment(int id)
        {
            if (id == 0)
                return BadRequest();

            var appointmentToDelete = _appointmentRepository.GetAppointmentById(id);
            if (appointmentToDelete == null)
                return NotFound();

            _appointmentRepository.DeleteAppointment(id);

            return NoContent();
        }
    }
}
