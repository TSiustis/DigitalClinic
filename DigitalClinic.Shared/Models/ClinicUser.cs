
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClinic.Shared.Models
{
    public class ClinicUser : IdentityUser
    {
        public string  Password { get; set; }
        public string Mobile { get; set; }
        public string  Name { get; set; }
        public string  ImageUrl { get; set; }
        public string ApiToken { get; set; }
    

            
        }
    }

