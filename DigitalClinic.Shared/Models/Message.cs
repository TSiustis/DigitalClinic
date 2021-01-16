using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClinic.Shared.Models
{
    public class Message
    {
        public int Id { get; set; }
        public ClinicUser Sender;
        public DateTimeOffset Time { get; set; }
        public string Text { get; set; }
        public bool IsOnline { get; set; }
        public bool Unread { get; set; }

       
            
        
    }
}
