using DigitalClinic.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClinic.Server.Repository
{
    public interface IClinicRepository
    {
        IEnumerable<Clinic> GetAllClinics();
        Clinic GetClinicById(int clinicId);
        Clinic AddClinic(Clinic clinic);
        Clinic UpdateClinic(Clinic clinic);
        void DeleteClinic(int clinicId);
    }
}
