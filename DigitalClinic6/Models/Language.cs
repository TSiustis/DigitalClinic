using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClinic6.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string EnglishName { get; set; }
        public  string LocalName { get; set; }
        public string Flag { get; set; }
        public bool Selected { get; set; }

    }
}
