using DigitalClinic.Server.Data;
using DigitalClinic.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClinic.Server.Repository
{
    public class ClinicRepository : IClinicRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ClinicRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Clinic> GetAllClinics()
        {
            return _applicationDbContext.Clinic;
        }
        public Clinic GetClinicById(int ClinicId)
        {
            return _applicationDbContext.Clinic.FirstOrDefault(d => d.Id == ClinicId);
        }
        public Clinic AddClinic(Clinic Clinic)
        {
            var addedEntity = _applicationDbContext.Clinic.Add(Clinic);
            _applicationDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public Clinic UpdateClinic(Clinic Clinic)
        {
            var foundClinic = _applicationDbContext.Clinic.FirstOrDefault(d => d.Id == Clinic.Id);
            if (foundClinic != null)
            {
                foundClinic.Address = Clinic.Address;
                foundClinic.Distance = Clinic.Distance;
                foundClinic.Image = Clinic.Image;
                foundClinic.Name = Clinic.Name;
                foundClinic.Rating = Clinic.Rating;
                
                return foundClinic;
            }
            return null;
        }
        public void DeleteClinic(int ClinicId)
        {
            var foundClinic = _applicationDbContext.Clinic.FirstOrDefault(d => d.Id == ClinicId);
            if (foundClinic == null) return;
            _applicationDbContext.Clinic.Remove(foundClinic);
            _applicationDbContext.SaveChanges();
        }
    }
}
