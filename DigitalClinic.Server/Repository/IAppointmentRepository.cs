using DigitalClinic.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClinic.Server.Repository
{
    public interface IAppointmentRepository
    {
        IEnumerable<Appointment> GetAllAppointments();
        Appointment GetAppointmentById(int doctorId);
        Appointment AddAppointment(Appointment doctor);
        Appointment UpdateAppointment(Appointment doctor);
        void DeleteAppointment(int appointmentId);
    }
}
