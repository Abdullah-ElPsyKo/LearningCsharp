using pokemongame;
namespace Pokemon_Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef de health base in van de pokemon: ");
            int hpbase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef de attack base in van de pokemon: ");
            int attba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef de defence base in van de pokemon: ");
            int defba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef de speed base in van de pokemon: ");
            int speedba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef de special attack in van de pokemon: ");
            int attsp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef de special defence in van de pokemon: ");
            int defsp = Convert.ToInt32(Console.ReadLine());

            Pokemon Bulb = new Pokemon();
            Bulb.Attack_Base = attba;
            Bulb.HP_Base = hpbase;
            Bulb.Defense_Base = defba;
            Bulb.Naam = "Bulbasaur";
            Bulb.Nummer = 0001;
            Bulb.Type = TypePok.grass;
            Bulb.SpecialAttack_Base = attsp;
            Bulb.SpecialDefense_Base = defsp;
            Bulb.Speed_Base = speedba;

            Bulb.ShowInfo();

            Console.WriteLine("\n\nTot welke level moet de pokemon gelevelled worden: ");
            int level = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < level; i++)
            {
                Bulb.VerhoogLevel();
            }
            Console.WriteLine($"\nNa {level} keer het level te verhogen:\n");

            Bulb.ShowInfo();
        }
    }
}