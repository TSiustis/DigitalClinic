
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClinic.Shared.Models
{
   public  class ClinicUser :IdentityUser
    {
        public string  Password { get; set; }
        public string Mobile { get; set; }
        public string  Name { get; set; }
        public string  ImageUrl { get; set; }
        public string ApiToken { get; set; }
    
        private List<ClinicUser> ClinicUsers { get; set; }
        public ClinicUser()
        {
            ClinicUsers = new List<ClinicUser> {
                // YOU - current user
                new ClinicUser {
                    Id = "0",
                    Name = "Shin Ye Eun",
                    ImageUrl = "assets/images/user-profile.jpg"
                },

            // USERS
                new ClinicUser {
               Id =  "1",
              Name =  "Dr Greg",
              ImageUrl =  "assets/images/doctor-2.jpg"
                },
            new  ClinicUser {
              Id =  "2",
              Name =  "Dr James",
              ImageUrl =  "assets/images/doctor-4.jpg"
            },
           new ClinicUser{
              Id = "3",
              Name =  "Dr John",
              ImageUrl =  "assets/images/doctor-4.jpg"
           },
            new ClinicUser{
              Id =  "4",
              Name =  "Dr Olivia",
              ImageUrl = "assets/images/doctor-3.jpg"
            },
            new ClinicUser{
              Id =  "5",
              Name =  "Dr Sam",
              ImageUrl = "assets/images/doctor-6.jpg",
            },
           new ClinicUser{
              Id = "6",
              Name =  "Dr Sophia",
             ImageUrl ="assets/images/doctor-7.jpg"
           },
            new ClinicUser{
              Id = "7",
              Name =  "Dr Steven",
              ImageUrl =  "assets/images/doctor-5.jpg"
            }
        };

            
        }
    }
}
