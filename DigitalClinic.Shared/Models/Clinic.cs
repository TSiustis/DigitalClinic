using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClinic.Shared.Models
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Distance { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        private List<Clinic> clinicList = new List<Clinic>();

        public Clinic()
        {
            clinicList.AddRange(new List<Clinic> {
                 new Clinic{Id = 1, Name ="Care Medical Clinic", Image = "assets/images/clinic-1.jpg",
      Distance = "10 km away", Address = "San Francisco", Rating = 4.7},
  new Clinic{Id = 2, Name ="The Pain Medic",  Image = "assets/images/clinic-2.jpg",Distance = "12 km away",
    Address =   "San Francisco", Rating = 4.2},
  new Clinic{Id = 3, Name = "Family Health Hospital", Image = "assets/images/clinic-3.jpg",
      Distance = "13 km away",Address = " San Francisco",Rating = 4.5},
  new Clinic{Id = 4, Name = "Universal Body Clinic", Image = "assets/images/clinic-1.jpg",
      Distance = "14 km away", Address ="San Francisco", Rating = 4.8},
  new Clinic {Id = 5, Name = "Helping Hands Health Center", Image = "assets/images/clinic-3.jpg",
      Distance = "1 km away", Address = "San Francisco", Rating = 4.1 },
  new Clinic{Id = 6, Name = "Helping Hands Health Center", Image = "assets/images/clinic-2.jpg" ,
      Distance = "4 km away", Address = "San Francisco",Rating = 4.1 },
 new  Clinic{Id = 7, Name = "Fair Medical Centre", Image = "assets/images/clinic-3.jpg",
      Distance = "20 km away", Address = "San Francisco", Rating = 4.3},
  new Clinic{Id = 8, Name = "Inclusive Health Service", Image = "assets/images/clinic-1.jpg",
      Distance = "30 km away", Address = "San Francisco",Rating = 4.4 } });
        } 
    }
}
