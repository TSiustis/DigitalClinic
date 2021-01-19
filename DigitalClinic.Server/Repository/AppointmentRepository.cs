using DigitalClinic.Server.Data;
using DigitalClinic.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClinic.Server.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public AppointmentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Appointment> GetAllAppointments()
        {
            return _applicationDbContext.Apppointment.Include("Doctor");
        }
        public Appointment GetAppointmentById(int AppointmentId)
        {
            return _applicationDbContext.Apppointment.Include("Doctor").FirstOrDefault(d => d.Id == AppointmentId);
        }
        public Appointment AddAppointment(Appointment Appointment)
        {
            var addedEntity = _applicationDbContext.Apppointment.Add(Appointment);
            _applicationDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public Appointment UpdateAppointment(Appointment Appointment)
        {
            var foundAppointment = _applicationDbContext.Apppointment.FirstOrDefault(d => d.Id == Appointment.Id);
            if (foundAppointment != null)
            {
                foundAppointment.Fees = Appointment.Fees;
                foundAppointment.ReasonForVisit = Appointment.ReasonForVisit;
                foundAppointment.TimeAllocated = Appointment.TimeAllocated;
                foundAppointment.Upcoming = Appointment.Upcoming;
                foundAppointment.VisitDate = Appointment.VisitDate;
                foundAppointment.VisitTiming = Appointment.VisitTiming;
                foundAppointment.VisitType = Appointment.VisitType;
                _applicationDbContext.SaveChanges();
                return foundAppointment;
            }
            return null;
        }
        public void DeleteAppointment(int AppointmentId)
        {
            var foundAppointment = _applicationDbContext.Apppointment.FirstOrDefault(d => d.Id == AppointmentId);
            if (foundAppointment == null) return;
            _applicationDbContext.Apppointment.Remove(foundAppointment);
            _applicationDbContext.SaveChanges();
        }
    }
}
