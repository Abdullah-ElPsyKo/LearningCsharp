using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computerwinkel
{
    internal class Computeronderdeel
    {
        public int Prijs { get; set; }
        public int ID { get; set; }
        public bool InDoos { get; set; }
        public Computeronderdeel()
        {
            Random rangen = new Random();
            Prijs = rangen.Next(1, 1000);
            ID = rangen.Next(100, 999);
            if (rangen.Next(0,2) == 1)
            {
                InDoos = true;
            }
            else { InDoos= false; }
        }

        public void ToonInfo()
        {
            Console.WriteLine($"Prijs : {Prijs}, ID : {ID}, InDoos : {InDoos}");
        }
    }
}
