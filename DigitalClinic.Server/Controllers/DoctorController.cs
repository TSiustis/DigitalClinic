using DigitalClinic.Server.Repository;
using DigitalClinic.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClinic.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        [HttpGet]
        public IActionResult GetAllDoctors()
        {
            return Ok(_doctorRepository.GetAllDoctors());
        }


        [HttpGet("{id}")]
        public IActionResult GetDoctorById(int id)
        {
            return Ok(_doctorRepository.GetDoctorById(id));
        }

        [HttpPost]
        public IActionResult CreateDoctor([FromBody] Doctor doctor)
        {
            if (doctor == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var createdDoctor = _doctorRepository.AddDoctor(doctor);

            return Created("doctor", createdDoctor);
        }

        [HttpPut]
        public IActionResult UpdateDoctor([FromBody] Doctor doctor)
        {
            if (doctor == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var doctorToUpdate = _doctorRepository.GetDoctorById(doctor.Id);
            if (doctorToUpdate == null)
                return NotFound();

            _doctorRepository.UpdateDoctor(doctor);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            if (id == 0)
                return BadRequest();

            var doctorToDelete = _doctorRepository.GetDoctorById(id);
            if (doctorToDelete == null)
                return NotFound();

            _doctorRepository.DeleteDoctor(id);

            return NoContent();
        }
    }
}
