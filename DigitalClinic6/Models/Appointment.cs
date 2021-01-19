using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClinic6.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public VisitType VisitType { get; set; }
        public string TimeAllocated { get; set; }
        public int Fees { get; set; }
        public DateTimeOffset VisitDate { get; set; }
        public string VisitTiming { get; set; }
        public string ReasonForVisit { get; set; }
        public bool Upcoming { get; set; }
    }
    public enum VisitType
    {
        Video,
        Walk,
        Call
    }
}
