using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClinic6.Models
{
    public class Instructions
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Heading { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        List<Instructions> InstructionsList = new List<Instructions>();
        public Instructions()
        {
            InstructionsList.AddRange(new List<Instructions>
            {
                 new Instructions{
    Image = "assets/images/onboard1.png",
    Heading = "Welcome",
    Title = "to Digital Clinic",
    SubTitle = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Asperiores porro distinctio nemo excepturi labore?",
                 },
new Instructions { Image =   "assets/images/onboard2.png",
    Heading = "Ask",
    Title = "a Doctor Online",
    SubTitle = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Asperiores porro distinctio nemo excepturi labore?",
},
  new Instructions {
    Image = "assets/images/onboard3.png",
    Heading = "Physician",
    Title = "on You Doorstep",
   SubTitle =  "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Asperiores porro distinctio nemo excepturi labore?",
  } });
        }
    }

}
