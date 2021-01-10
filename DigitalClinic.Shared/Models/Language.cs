using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClinic.Shared.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string EnglishName { get; set; }
        public  string LocalName { get; set; }
        public string Flag { get; set; }
        public bool Selected { get; set; }

        public List<Language> Languages { get; set; }

        public Language()
        {
            Languages = new List<Language> { 
                 new Language{ Code = "en", EnglishName = "English", LocalName = "English", Flag = "assets/images/united-states-of-america.png" },
      new Language{ Code = "hi", EnglishName  = "Hindi",LocalName =  "हिंदी", Flag = "assets/images/india.png" },
      new Language{Code = "ar", EnglishName = "Arabic",LocalName =  "العربية", Flag = "assets/images/united-arab-emirates.png" },
      new Language{Code = "es", EnglishName = "Spanish", LocalName = "Spana", Flag = "assets/images/spain.png" },
      new Language{Code = "fr", EnglishName = "French (France)", LocalName = "Français - France", Flag =  "assets/images/france.png" },
      new Language{Code = "de", EnglishName = "German", LocalName = "Deutschland - France", Flag = "assets/images/germany.png" },
      new Language{Code = "ko", EnglishName = "Korean", LocalName = "Korean", Flag = "assets/images/korea.png" },
            };
        }
    }
}
