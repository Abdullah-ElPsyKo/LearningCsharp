using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef6
{
    internal class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        private DateTime min = new DateTime(1990,1,1);
        private DateTime vandaag = DateTime.Now;

        private int leeftijd;

        private DateTime geboortedatum;

        public DateTime GeboorteDatum
        {
            get { return geboortedatum; }
            set
            {
                if (value < min || value > vandaag)
                {
                    value = vandaag;
                } 
                else
                {
                    geboortedatum = value;
                }
            } 
        }

        public int BerekenLeeftijd()
        {
            if (vandaag.Day - GeboorteDatum.Day < 0 || vandaag.Month - GeboorteDatum.Month < 0)
            {
                leeftijd = vandaag.Year - GeboorteDatum.Year - 1;
                Console.WriteLine(leeftijd);
                return leeftijd;
            }
            else
            {
                leeftijd = vandaag.Year - GeboorteDatum.Year;
                Console.WriteLine(leeftijd);
                return leeftijd;
            }
        }
    }
}
