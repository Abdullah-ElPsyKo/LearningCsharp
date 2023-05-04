using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziekenhuis
{
    public class Patient
    {
        public string naam { get; set; }
        public int aantalUurSick { get; set; }

        private int basiskoste = 50;
        private int perUurKoste = 20;

        public virtual double BerekenKost()
        {
            return basiskoste + (perUurKoste * aantalUurSick);
        }

        public void ToonInfo()
        {
            Console.WriteLine($"{naam}: {aantalUurSick}\nKoste: {BerekenKost()}");
        }


    }
    public class VerzekerdePatient: Patient
    {
        public override double BerekenKost()
        {
            double verzekeringsKorting = 10 / 100.0;
            double bedrag = base.BerekenKost();
            return bedrag - (bedrag * verzekeringsKorting);
        }
    }
}
