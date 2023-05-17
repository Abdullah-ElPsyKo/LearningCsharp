namespace Ganzenbord_Dams_Van_Camp_editie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ganzenbord bord = new Ganzenbord(true);
            while (true)
            {
                Console.Clear();
                bord.TekenBord();
                int dbrol = Dobbelsteen.Rol();
                Console.WriteLine($"\nJe rolde {dbrol}");
                Console.ReadLine();
                if (bord.BeweegPion(dbrol))
                {
                    Console.WriteLine("Proficiat, je hebt gewonnen.");
                    break;
                }
            }
            Console.WriteLine("Je score is: " + bord.HuidigeScore); // display the final score
            Console.ReadLine();
        }
    }
}
