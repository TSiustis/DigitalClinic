using DigitalClinic.Shared.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClinic.Server.Data
{
    public class SeedData
    {
        private List<Clinic> clinicList = new List<Clinic>();
        private List<ClinicUser> ClinicUsers = new List<ClinicUser>();

        public List<Language> Languages = new List<Language>();

        public static List<ClinicUser> Favorites { get; set; } = new List<ClinicUser>
        {
               new ClinicUser{Name = "Sam" },
               new ClinicUser{Name = "Olivia" },
               new ClinicUser{Name = "Steven" },
               new ClinicUser{Name = "Greg" }
        };




        public static void Seed(IApplicationBuilder applicationBuilder)
        {

            var scope = applicationBuilder.ApplicationServices.CreateScope();

            ApplicationDbContext context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            context.AddRange(new List<Clinic>(){ new Clinic{ Name ="Care Medical Clinic", Image = "assets/images/clinic-1.jpg",
      Distance = "10 km away", Address = "San Francisco", Rating = 4.7},
  new Clinic{ Name ="The Pain Medic",  Image = "assets/images/clinic-2.jpg",Distance = "12 km away",
    Address =   "San Francisco", Rating = 4.2},
  new Clinic{ Name = "Family Health Hospital", Image = "assets/images/clinic-3.jpg",
      Distance = "13 km away",Address = " San Francisco",Rating = 4.5},
  new Clinic{ Name = "Universal Body Clinic", Image = "assets/images/clinic-1.jpg",
      Distance = "14 km away", Address ="San Francisco", Rating = 4.8},
  new Clinic { Name = "Helping Hands Health Center", Image = "assets/images/clinic-3.jpg",
      Distance = "1 km away", Address = "San Francisco", Rating = 4.1 },
  new Clinic{ Name = "Helping Hands Health Center", Image = "assets/images/clinic-2.jpg" ,
      Distance = "4 km away", Address = "San Francisco",Rating = 4.1 },
 new  Clinic{ Name = "Fair Medical Centre", Image = "assets/images/clinic-3.jpg",
      Distance = "20 km away", Address = "San Francisco", Rating = 4.3},
  new Clinic{ Name = "Inclusive Health Service", Image = "assets/images/clinic-1.jpg",
      Distance = "30 km away", Address = "San Francisco",Rating = 4.4 } });



            context.AddRange(new List<ClinicUser>() {
                // YOU - current user
                new ClinicUser {
                    
                    Name = "Shin Ye Eun",
                    ImageUrl = "assets/images/user-profile.jpg"
                },
                new ClinicUser {
              
              Name =  "Dr Greg",
              ImageUrl =  "assets/images/doctor-2.jpg"
                },
            new  ClinicUser {
              
              Name =  "Dr James",
              ImageUrl =  "assets/images/doctor-4.jpg"
            },
           new ClinicUser{
             
              Name =  "Dr John",
              ImageUrl =  "assets/images/doctor-4.jpg"
           },
            new ClinicUser{
              
              Name =  "Dr Olivia",
              ImageUrl = "assets/images/doctor-3.jpg"
            },
            new ClinicUser{
             
              Name =  "Dr Sam",
              ImageUrl = "assets/images/doctor-6.jpg",
            },
           new ClinicUser{
              
              Name =  "Dr Sophia",
             ImageUrl ="assets/images/doctor-7.jpg"
           },
            new ClinicUser{
              
              Name =  "Dr Steven",
              ImageUrl =  "assets/images/doctor-5.jpg"
            }});


      //      context.AddRange(new List<Language>() {
      //           new Language{ Code = "en", EnglishName = "English", LocalName = "English", Flag = "assets/images/united-states-of-america.png" },
      //new Language{ Code = "hi", EnglishName  = "Hindi",LocalName =  "हिंदी", Flag = "assets/images/india.png" },
      //new Language{Code = "ar", EnglishName = "Arabic",LocalName =  "العربية", Flag = "assets/images/united-arab-emirates.png" },
      //new Language{Code = "es", EnglishName = "Spanish", LocalName = "Spana", Flag = "assets/images/spain.png" },
      //new Language{Code = "fr", EnglishName = "French (France)", LocalName = "Français - France", Flag =  "assets/images/france.png" },
      //new Language{Code = "de", EnglishName = "German", LocalName = "Deutschland - France", Flag = "assets/images/germany.png" },
      //new Language{Code = "ko", EnglishName = "Korean", LocalName = "Korean", Flag = "assets/images/korea.png" },
      //      });

            if (!context.Message.Any())
            {
                context.AddRange(new List<Message> {
              new  Message{
    Sender = Favorites[0],
   Time =  new DateTimeOffset(2020,03,22,17,14,55,new TimeSpan(1,0,0)),
    Text =  "Hey, how\'s it going? What did you do today?",
    IsOnline =false,
    Unread =  true
  },
  new Message {
    Sender =  Favorites[1],
    Time = new DateTimeOffset(2020, 03, 22, 17, 14, 55, new TimeSpan(1, 0, 0)),
   Text =  "Hey, how\'s it going? What did you do today?",
    IsOnline = false,
    Unread =  true
  },
  new Message{
    Sender = Favorites[2],
    Time = new DateTimeOffset(2020,03,22,17,14,55,new TimeSpan(1,0,0)),
    Text = "Hey, how\'s it going? What did you do today?Hey, how\'s it going? What did you do today?Hey, how\'s it going? What did you do today?Hey, how\'s it going? What did you do today?",
    IsOnline  = false,
    Unread =  false
  },
  new Message {
    Sender = Favorites[3],
    Time = new DateTimeOffset(2020, 03, 22, 17, 14, 55, new TimeSpan(1, 0, 0)),
    Text = "Hey, how\'s it going? What did you do today?",
    IsOnline = false,
    Unread = true
  },

  new Message{
    Sender =  Favorites[3],
    Time =  new DateTimeOffset(2020,03,22,17,14,55,new TimeSpan(1,0,0)),
    Text=  "Hey, how\'s it going? What did you do today?",
    IsOnline = false,
    Unread =  false
  },
  new Message{
    Sender = Favorites[3],
    Time =  new DateTimeOffset(2020,03,22,17,14,55,new TimeSpan(1,0,0)),
    Text =  "Hey, how\'s it going? What did you do today?",
    IsOnline =  false,
    Unread =  false
  },
  new Message{
   Sender = Favorites[3],
    Time = new DateTimeOffset(2020,03,22,17,14,55,new TimeSpan(1,0,0)),
    Text = "Hey, how\'s it going? What did you do today?",
    IsOnline  =  false,
    Unread = false
  } });
                if (!context.Doctor.Any())
                {
                    context.AddRange(
                           new List<Doctor> {
  new Doctor{  Name = "Dr. Sam Deniel", Image = "assets/images/doctor-1.jpg", Speciality = "Anesthesiologist", Rating= 4.5,Distance = 2, ReviewCount = 100, Experience = 10, Address = "San Francisco", IsFeatured = true,
     Location =  new Location(latitude: 22.7378099, longitude: 75.8847639) },
  new Doctor { Name = "Dr. Anni Youk", Image = "assets/images/doctor-2.jpg", Speciality = "Anesthesiologist", Rating = 4.0, Distance = 50, ReviewCount = 80, Experience = 8, Address = "New York", IsFeatured = true,
      Location = new Location(latitude: 22.7369102, longitude: 75.8805883)},
  new Doctor{ Name = "Dr. Emma Meaburn", Image =  "assets/images/doctor-3.jpg",Speciality ="Dermatologist",Rating =  5.0, Distance = 20, ReviewCount = 10, Experience = 10, Address = "Washington DC", IsFeatured = false,
      Location = new Location(latitude: 22.7323716, longitude: 75.8805436)},
 new  Doctor{ Name = "Dr. Sam Deniel", Image = "assets/images/doctor-4.jpg", Speciality = "Anesthesiologist", Rating = 4.5, Distance = 20,ReviewCount =  100, Experience = 10, Address = "San Francisco", IsFeatured =  true,
     Location = new  Location(latitude: 22.7323716, longitude: 75.8805436) },
  new Doctor{ Name = "Dr. Anni Youk", Image = "assets/images/doctor-5.jpg", Speciality = "Anesthesiologist", Rating = 4.0, Distance = 50, ReviewCount = 80, Experience = 8, Address = "New York", IsFeatured = true,
     Location = new  Location(latitude: 22.7335044, longitude: 75.8871637) },
  new Doctor{ Name ="Dr. Emma Meaburn", Image = "assets/images/doctor-6.jpg", Speciality = "Dermatologist", Rating = 5.0, Distance = 20,ReviewCount =  10, Experience = 10, Address = "Washington DC",IsFeatured =  false,
     Location = new  Location(latitude: 22.7335044, longitude: 75.8871637) },
  new Doctor{ Name = "Dr. Sam Deniel", Image = "assets/images/doctor-7.jpg", Speciality = "Anesthesiologist", Rating = 4.5, Distance = 20, ReviewCount = 100, Experience = 10,Address =  "San Francisco", IsFeatured = true,
     Location = new  Location(latitude: 22.7382716, longitude: 75.8830617)},
  new Doctor{Name =  "Dr. Anni Youk", Image = "assets/images/doctor-2.jpg",  Speciality = "Anesthesiologist", Rating = 4.0,Distance =  50, ReviewCount = 80, Experience = 8, Address = "New York", IsFeatured = true,
      Location =  new  Location(latitude: 22.7349123, longitude: 22.7349123) },
 new  Doctor{ Name = "Dr. Emma Meaburn", Image = "assets/images/doctor-3.jpg", Speciality = "Dermatologist", Rating = 5.0, Distance = 20, ReviewCount = 10, Experience = 10,Address =  "Washington DC",IsFeatured=  false,
     Location = new  Location(latitude: 22.7349014, longitude: 22.7349014) },
 new  Doctor{ Name = "Dr. Sam Deniel", Image = "assets/images/doctor-1.jpg", Speciality = "Anesthesiologist",Rating =  4.5, Distance = 20, ReviewCount = 100, Experience = 10,Address  = "San Francisco", IsFeatured = true,
    Location = new   Location(latitude: 22.7343749, longitude: 75.8838529) },
 new  Doctor{ Name = "Dr. Anni Youk", Image = "assets/images/doctor-2.jpg", Speciality = "Anesthesiologist", Rating = 4.0, Distance = 50, ReviewCount = 80, Experience =  8, Address = "New York", IsFeatured = true,
     Location = new  Location(latitude: 22.7329246, longitude: 75.8890038) },
 new  Doctor{ Name = "Dr. Emma Meaburn", Image = "assets/images/doctor-3.jpg", Speciality = "Dermatologist", Rating = 5.0, Distance = 20, ReviewCount = 10, Experience = 10, Address = "Washington DC", IsFeatured = false,
     Location = new  Location(latitude: 22.7328935, longitude: 75.8891046)} });
                }
            }
            context.SaveChanges();
        }

    }



}



