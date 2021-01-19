using DigitalClinic.Server.Repository;
using DigitalClinic.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigitalClinic.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClinicsController : ControllerBase
    {
        private readonly IClinicRepository _ClinicRepository;

        public ClinicsController(IClinicRepository ClinicRepository)
        {
            _ClinicRepository = ClinicRepository;
        }

        [HttpGet]
        public IActionResult GetAllClinics()
        {
            return Ok(_ClinicRepository.GetAllClinics());
        }


        [HttpGet("{id}")]
        public IActionResult GetClinicById(int id)
        {
            return Ok(_ClinicRepository.GetClinicById(id));
        }

        [HttpPost]
        public IActionResult CreateClinic([FromBody] Clinic clinic)
        {
            if (clinic == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var createdClinic = _ClinicRepository.AddClinic(clinic);

            return Created("clinic", createdClinic);
        }

        [HttpPut]
        public IActionResult UpdateClinic([FromBody] Clinic Clinic)
        {
            if (Clinic == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var ClinicToUpdate = _ClinicRepository.GetClinicById(Clinic.Id);
            if (ClinicToUpdate == null)
                return NotFound();

            _ClinicRepository.UpdateClinic(Clinic);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClinic(int id)
        {
            if (id == 0)
                return BadRequest();

            var ClinicToDelete = _ClinicRepository.GetClinicById(id);
            if (ClinicToDelete == null)
                return NotFound();

            _ClinicRepository.DeleteClinic(id);

            return NoContent();
        }
    }
}
