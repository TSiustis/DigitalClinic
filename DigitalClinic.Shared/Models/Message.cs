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

        public List<ClinicUser> Favorites { get; set; } = new List<ClinicUser>
        {
               new ClinicUser{Name = "Sam" },
               new ClinicUser{Name = "Olivia" },
               new ClinicUser{Name = "Steven" },
               new ClinicUser{Name = "Greg" }
        };
        public List<Message> Chats { get; set; }
        public Message()
        {
            Chats = new List<Message> {
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
    Sender =  Favorites[4],
    Time =  new DateTimeOffset(2020,03,22,17,14,55,new TimeSpan(1,0,0)),
    Text=  "Hey, how\'s it going? What did you do today?",
    IsOnline = false,
    Unread =  false
  },
  new Message{
    Sender = Favorites[5],
    Time =  new DateTimeOffset(2020,03,22,17,14,55,new TimeSpan(1,0,0)),
    Text =  "Hey, how\'s it going? What did you do today?",
    IsOnline =  false,
    Unread =  false
  },
  new Message{
   Sender = Favorites[6],
    Time = new DateTimeOffset(2020,03,22,17,14,55,new TimeSpan(1,0,0)),
    Text = "Hey, how\'s it going? What did you do today?",
    IsOnline  =  false,
    Unread = false
  } };
            
        }
    }
}
