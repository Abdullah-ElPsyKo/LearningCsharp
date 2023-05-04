using digitalekluis;

namespace oef1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DigitaleKluis kluisje = new DigitaleKluis(9999);
            DigitaleKluis.BruteForce(kluisje);
        }
    }
}