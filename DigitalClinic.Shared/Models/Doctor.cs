using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClinic.Shared.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Speciality { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        public double Distance { get; set; }
        public double Experience { get; set; }
        public int ReviewCount { get; set; }
        public bool IsFeatured { get; set; }
        public Location Location { get; set; }

        
    }
}
