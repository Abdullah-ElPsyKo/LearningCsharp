using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef4
{
    internal class BibBoek
    {
        public string Ontlener { get; set; } = "onbekend";
        private DateTime uitgeleend = DateTime.Now;

        private static int uitleendagen = 14;

        public DateTime Uitgeleend { private get { return uitgeleend; } set { uitgeleend = value; } }
        public DateTime InLeverDatum { get { return uitgeleend.AddDays(uitleendagen); } }

        public void VerlengTermijn(int a)
        {
            uitgeleend = uitgeleend.AddDays(3);
        }

        public BibBoek()
        {
            Uitgeleend = Uitgeleend.AddDays(-1);
        }
        public BibBoek(string uitlener, DateTime uitgeleendin)
        {
            if (uitgeleendin > DateTime.Now)
            {
                throw new Exception("De uitgeleend datum kan niet later zijn dan de huidige datum.");
            }
            else
            {
                Uitgeleend = uitgeleendin;
                Ontlener = uitlener;
            }
        }
        public static void VeranderAlgemeneUitleenTermijn(int a)
        {
            uitleendagen = a;
        }
    }
}
