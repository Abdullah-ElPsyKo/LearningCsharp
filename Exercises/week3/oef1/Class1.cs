using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalekluis
{
    public class DigitaleKluis
    {
        public bool CanShowCode { get; set; }

		private int code;

		public int Code
		{
			get
			{
				if (CanShowCode == true)
                {
					return code;
				}
				else
				{
					return -666;
				}
			}
			private set { code = value; }
		}

		public DigitaleKluis(int getal)
		{
			Code = getal;
		}

		public int CodeLevel { get { return (code / 1000); } }

		private int aantalPogingen = 0;

		public bool TryCode(int getal)
		{
			if (aantalPogingen<10)
			{
				aantalPogingen++;
                if (code == getal)
                {
                    Console.WriteLine($"Deze code is geldig. Aantalpogingen = {aantalPogingen}");
                    return true;
                }
                else
                {
                    if (getal == -666)
                    {
                        Console.WriteLine("CHEATER");
						return false;
                    }
                    Console.WriteLine("geen geldige code");
                    return false;
                }
            }
			else
			{
				Console.WriteLine("Je hebt je 10 pogingen opgebruikt.Sorry.");
				return false;
			}
			
		}

		//bruteforce

		public static void BruteForce(DigitaleKluis kluis)
		{
			Random rangen = new Random();
			for (int i = 0; i < 10; i++)
			{
				int rancomb = rangen.Next(1,9999);
				Console.WriteLine(rancomb);
				if (kluis.TryCode(rancomb) == true)
				{
					break;
				}
            }
		}

    }
}
