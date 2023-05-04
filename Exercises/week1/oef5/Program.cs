namespace oef5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rekening rekening1 = new Rekening();
            //rekening1.Naam = "Salim";
            //rekening1.RekeningNummer = "BE12 3456 7890 1234 21";
            //rekening1.StortGeld(500);
            //rekening1.ToonInfo();


            Rekening rekening2 = new ProRekening();
            rekening2.Naam = "Abdullah";
            rekening2.RekeningNummer = "BE12 3456 7890 1234 21";
            rekening2.StortGeld(4000);
            rekening2.ToonInfo();

            Console.WriteLine("\n");

            Console.WriteLine(rekening2.BerekenRente());

            //rekening2.StortGeld(rekening1.HaalGeldAf(300));
            //rekening2.ToonInfo(); 
            //rekening1.ToonInfo();
        }
    }
}