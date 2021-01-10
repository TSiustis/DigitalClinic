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

        List<Doctor> Doctors = new List<Doctor>();

        public Doctor()
        {
            Doctors.AddRange(
        new List<Doctor> {
  new Doctor{ Id = 1, Name = "Dr. Sam Deniel", Image = "assets/images/doctor-1.jpg", Speciality = "Anesthesiologist", Rating= 4.5,Distance = 2, ReviewCount = 100, Experience = 10, Address = "San Francisco", IsFeatured = true,
     Location =  new Location(latitude: 22.7378099, longitude: 75.8847639) },
  new Doctor { Id = 2, Name = "Dr. Anni Youk", Image = "assets/images/doctor-2.jpg", Speciality = "Anesthesiologist", Rating = 4.0, Distance = 50, ReviewCount = 80, Experience = 8, Address = "New York", IsFeatured = true,
      Location = new Location(latitude: 22.7369102, longitude: 75.8805883)},
  new Doctor{Id = 3, Name = "Dr. Emma Meaburn", Image =  "assets/images/doctor-3.jpg",Speciality ="Dermatologist",Rating =  5.0, Distance = 20, ReviewCount = 10, Experience = 10, Address = "Washington DC", IsFeatured = false,
      Location = new Location(latitude: 22.7323716, longitude: 75.8805436)},
 new  Doctor{Id = 4, Name = "Dr. Sam Deniel", Image = "assets/images/doctor-4.jpg", Speciality = "Anesthesiologist", Rating = 4.5, Distance = 20,ReviewCount =  100, Experience = 10, Address = "San Francisco", IsFeatured =  true,
     Location = new  Location(latitude: 22.7323716, longitude: 75.8805436) },
  new Doctor{Id = 5, Name = "Dr. Anni Youk", Image = "assets/images/doctor-5.jpg", Speciality = "Anesthesiologist", Rating = 4.0, Distance = 50, ReviewCount = 80, Experience = 8, Address = "New York", IsFeatured = true,
     Location = new  Location(latitude: 22.7335044, longitude: 75.8871637) },
  new Doctor{Id = 6, Name ="Dr. Emma Meaburn", Image = "assets/images/doctor-6.jpg", Speciality = "Dermatologist", Rating = 5.0, Distance = 20,ReviewCount =  10, Experience = 10, Address = "Washington DC",IsFeatured =  false,
     Location = new  Location(latitude: 22.7335044, longitude: 75.8871637) },
  new Doctor{Id = 7, Name = "Dr. Sam Deniel", Image = "assets/images/doctor-7.jpg", Speciality = "Anesthesiologist", Rating = 4.5, Distance = 20, ReviewCount = 100, Experience = 10,Address =  "San Francisco", IsFeatured = true,
     Location = new  Location(latitude: 22.7382716, longitude: 75.8830617)},
  new Doctor{Id = 8,Name =  "Dr. Anni Youk", Image = "assets/images/doctor-2.jpg",  Speciality = "Anesthesiologist", Rating = 4.0,Distance =  50, ReviewCount = 80, Experience = 8, Address = "New York", IsFeatured = true,
      Location =  new  Location(latitude: 22.7349123, longitude: 22.7349123) },
 new  Doctor{Id = 9, Name = "Dr. Emma Meaburn", Image = "assets/images/doctor-3.jpg", Speciality = "Dermatologist", Rating = 5.0, Distance = 20, ReviewCount = 10, Experience = 10,Address =  "Washington DC",IsFeatured=  false,
     Location = new  Location(latitude: 22.7349014, longitude: 22.7349014) },
 new  Doctor{Id = 10, Name = "Dr. Sam Deniel", Image = "assets/images/doctor-1.jpg", Speciality = "Anesthesiologist",Rating =  4.5, Distance = 20, ReviewCount = 100, Experience = 10,Address  = "San Francisco", IsFeatured = true,
    Location = new   Location(latitude: 22.7343749, longitude: 75.8838529) },
 new  Doctor{ Id = 11,Name = "Dr. Anni Youk", Image = "assets/images/doctor-2.jpg", Speciality = "Anesthesiologist", Rating = 4.0, Distance = 50, ReviewCount = 80, Experience =  8, Address = "New York", IsFeatured = true,
     Location = new  Location(latitude: 22.7329246, longitude: 75.8890038) },
 new  Doctor{Id = 12, Name = "Dr. Emma Meaburn", Image = "assets/images/doctor-3.jpg", Speciality = "Dermatologist", Rating = 5.0, Distance = 20, ReviewCount = 10, Experience = 10, Address = "Washington DC", IsFeatured = false,
     Location = new  Location(latitude: 22.7328935, longitude: 75.8891046)} });
        }
    }
}
