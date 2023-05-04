using pokemongame;

namespace oef1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon pok1 = Pokemon.GeneratorPokemon();
            Pokemon pok2 = Pokemon.GeneratorPokemon();

            Pokemon.NoLevelingAllowed = false;

            for (int i = 0; i < 6; i++)
            {
                pok1.ShowInfo();
                pok2.ShowInfo();
                int TheBattle = Pokemon.Battle(pok1, pok2);
                Console.WriteLine($"\nWie heeft gewonnen?: {TheBattle}\n"); 
                if (TheBattle == 1)
                {
                    Console.WriteLine("Pokemon 1: +1 level");
                    pok1.VerhoogLevel();
                    pok2 = Pokemon.GeneratorPokemon();
                }
                else if (TheBattle == 2)
                {
                    Console.WriteLine("Pokemon 2: +1 level");
                    pok2.VerhoogLevel();
                    pok1 = Pokemon.GeneratorPokemon();
                }
                else
                {
                    pok1 = Pokemon.GeneratorPokemon();
                    pok2 = Pokemon.GeneratorPokemon();
                }
            }
            Pokemon.Info();
        }
    }
}