using DigitalClinic.Server.Data;
using DigitalClinic.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClinic.Server.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public DoctorRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
     public IEnumerable<Doctor> GetAllDoctors()
        {
            return _applicationDbContext.Doctor;
        }
        public Doctor GetDoctorById(int doctorId)
        {
            return _applicationDbContext.Doctor.FirstOrDefault(d => d.Id == doctorId);
        }
        public Doctor AddDoctor(Doctor doctor)
        {
            var addedEntity = _applicationDbContext.Doctor.Add(doctor);
            _applicationDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public Doctor UpdateDoctor(Doctor doctor)
        {
            var foundDoctor = _applicationDbContext.Doctor.FirstOrDefault(d => d.Id == doctor.Id);
            if(foundDoctor != null)
            {
                foundDoctor.Image = doctor.Image;
                foundDoctor.Experience = doctor.Experience;
                foundDoctor.Address = doctor.Address;
                foundDoctor.Distance = doctor.Distance;
                foundDoctor.IsFeatured = doctor.IsFeatured;
                foundDoctor.Name = doctor.Name;
                foundDoctor.Rating = doctor.Rating;
                foundDoctor.ReviewCount = doctor.ReviewCount;
                foundDoctor.Speciality = doctor.Speciality;

                _applicationDbContext.SaveChanges();
                return foundDoctor;
            }
            return null;
        }
        public void DeleteDoctor(int doctorId)
        {
            var foundDoctor = _applicationDbContext.Doctor.FirstOrDefault(d => d.Id == doctorId);
            if (foundDoctor == null) return;
            _applicationDbContext.Doctor.Remove(foundDoctor);
            _applicationDbContext.SaveChanges();
        }
    }
}
