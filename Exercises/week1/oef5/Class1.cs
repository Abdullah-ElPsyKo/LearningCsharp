using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef5
{
    public enum RekeningStaat { Geldig, Geblokkeerd }
    public abstract class Rekening
    {
        public string Naam { get; set; }
        public string RekeningNummer { get; set; }
        private int balans;
        public int Balans { get { return balans; } }

        public RekeningStaat Staat { get; set; } = RekeningStaat.Geldig;

        public int HaalGeldAf(int a)
        {
            if (Staat == RekeningStaat.Geldig)
            {
                if (a > balans)
                {
                    Console.WriteLine("Rekening leeg nu.");
                    balans -= balans;
                    return balans;
                }
                else
                {
                    balans -= a;
                    return a;
                }
            }
            else
            {
                Console.WriteLine("Rekening leeg nu.");
                return 0;
            }
            
            
        }
        public void StortGeld(int a)
        {
            if (Staat == RekeningStaat.Geldig)
            {
                balans += a;
            }
            else
            {
                Console.WriteLine("Gaat niet. Rekening geblokkeerd.");
            }
        }
        public void ToonInfo()
        {
            Console.WriteLine($"Naam: {Naam}\nRekeningnummer: {RekeningNummer}\nBalans: {balans}\nStaat: {Staat}");
        }

        
        public void VeranderStaat()
        {
            if (Staat == RekeningStaat.Geblokkeerd)
            {
                Staat = RekeningStaat.Geldig;
            }
            else
            {
                Staat = RekeningStaat.Geblokkeerd;
            }
        }

        public abstract double BerekenRente();
    }

    class BankRekening : Rekening
    {
        public override double BerekenRente()
        {
            if (Balans < 100)
            {
                return Balans;
            }
            else
            {
                return (Balans + (Balans * 5 / 100));

            }
        }
    }
    class SpaarRekening : Rekening
    {
        public override double BerekenRente()
        {
            return (Balans + (Balans * 2 / 100));
        }
    }
    class ProRekening : Rekening
    {
        public override double BerekenRente()
        {
            int thousands = 0;

            thousands = Balans / 1000; //if balans would be a double (which has to be one, me is just lazy :D) --> (int)Balans / 1000

            return ((thousands * 10) + (Balans + (Balans * 2 / 100)));
        }
    }
}
