namespace oef6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoon pers1 = new Persoon();

            pers1.Voornaam = "Abdullah";
            pers1.Achternaam = "Bagishev";
            pers1.GeboorteDatum = new DateTime(2002,2,15);
            pers1.BerekenLeeftijd();
        }
    }
}