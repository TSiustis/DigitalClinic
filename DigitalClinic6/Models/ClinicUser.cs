

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClinic6.Models
{
   public  class ClinicUser : IdentityUser
    {
        public string  Password { get; set; }
        public string Mobile { get; set; }
        public string  ImageUrl { get; set; }
        public string ApiToken { get; set; }
    

            
        }
    }

