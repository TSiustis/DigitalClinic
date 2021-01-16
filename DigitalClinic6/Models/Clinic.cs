using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClinic6.Models
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Distance { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

    }
}
