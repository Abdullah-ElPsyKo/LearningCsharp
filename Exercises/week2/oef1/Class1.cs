using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemongame
{
    public enum TypePok { grass, poison}
    public class Pokemon
    {
        private int hp_Base;
        public int HP_Base { get { return hp_Base; } set { hp_Base = value; } }

        private int attack_Base;
        public int Attack_Base { get { return attack_Base; } set { attack_Base = value; } }

        private int defense_Base;
        public int Defense_Base { get { return defense_Base; } set { defense_Base = value; } }

        private int speed_Base;
        public int Speed_Base { get { return speed_Base; } set { speed_Base = value; } }

        private int specialAttack_Base;
        public int SpecialAttack_Base { get { return specialAttack_Base; } set { specialAttack_Base = value; } } 

        private int specialDefense_Base;
        public int SpecialDefense_Base { get { return specialDefense_Base; } set { specialDefense_Base= value; } }

        public static int aantalLevelUps { get; private set; }
        public static int aantalBattles { get; private set; }
        public static int aantalDraws { get; private set; }
        public static int aantalRandomPokemons { get; private set; }

        public static bool NoLevelingAllowed = false;

        public Pokemon() //default stats = 10
        {
            HP_Base = 10;
            Attack_Base= 10;
            Defense_Base = 10;
            Speed_Base = 10;
            SpecialAttack_Base = 10;
            SpecialDefense_Base = 10;
        }

        public Pokemon(int hp, int att, int def, int spd, int specAtt, int specDef) //overloaded constructor with stats
        {
            HP_Base= hp;
            Attack_Base= att;
            Defense_Base= def;
            Speed_Base= spd;
            SpecialAttack_Base= specAtt;
            SpecialDefense_Base= specDef;
        }
        public string Naam { get; set; }
        public TypePok Type { get; set; }
        public int Nummer { get; set; }

        private int level;
        public int Level { get { return level; } private set { level = value; } }

        //level up everytime called
        public void VerhoogLevel()
        {
            if (NoLevelingAllowed == false)
            {
                level++;
                aantalLevelUps++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nLevel up is niet mogelijk.");
                Console.ResetColor();
            }
        }

        public double Average { get { return (HP_Base + Attack_Base + Defense_Base + Speed_Base + SpecialAttack_Base + SpecialDefense_Base)/6.0; } }
        public int Total { get { return (HP_Base + Attack_Base + Defense_Base + Speed_Base + SpecialAttack_Base + SpecialDefense_Base); } }

        public int HP_Full { get { 
                int resultaat = (((HP_Base + 50) * Level) / 50) + 10;
                return resultaat;
            } 
        }

        public int Attack_Full { get { return (((Attack_Base * Level) / 50) + 5); } }
        public int Defense_Full { get { return (((Defense_Base * Level) / 50) + 5); } }
        public int Speed_Full { get { return (((SpecialDefense_Base * Level) / 50 ) +5); } }
        public int SpecialAttack_Full { get { return (((SpecialAttack_Base * Level) / 50 ) +5); } }
        public int SpecialDefense_Full { get { return (((Speed_Base * Level) / 50 ) +5); } }

        public void ShowInfo()
        {
            Console.WriteLine($"\n{Naam}\n(level {Level})\n\nBase stats:\n   * Health: {HP_Base}\n   * Speed: {Speed_Base}\n   * Attack: {Attack_Base}\n   * Defense: {Defense_Base}\n   * Special attack: {SpecialAttack_Base}\n   * Special defense: {SpecialDefense_Base}");
            Console.WriteLine($"\nFull stats:\n   * Health: {HP_Full}\n   * Speed: {Speed_Full}\n   * Attack: {Attack_Full}\n   * Defense: {Defense_Full}\n   * Special attack: {SpecialAttack_Full}\n   * Special defense: {SpecialDefense_Full}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n*******************\n\nTotal: {Total}\nAverage: {Average}\n\n*******************");
            Console.ResetColor();
        }
        public static Pokemon GeneratorPokemon() //generate a pokemon with random stats
        {
            Pokemon pok1 = new Pokemon();
            Random rangen = new Random();

            pok1.Attack_Base = rangen.Next(1, 100);
            pok1.Defense_Base = rangen.Next(1, 100);
            pok1.HP_Base = rangen.Next(1, 100);
            pok1.Speed_Base = rangen.Next(1, 100);
            pok1.SpecialAttack_Base = rangen.Next(1, 100);
            pok1.SpecialDefense_Base = rangen.Next(1, 100);

            //for (int i = 0; i < rangen.Next(1, 50); i++)
            //{
            //    pok1.VerhoogLevel();
            //}

            pok1.Level = rangen.Next(1,50);

            aantalRandomPokemons++;
            return pok1;
        }
        public static int Battle(Pokemon poke1, Pokemon poke2) //simulate a battle between two pokemons
        {
            aantalBattles++;
            if (poke1 == null)
            {
                return 2;
            }
            else if (poke2 == null)
            {
                return 1;
            }
            else if (poke1 == null && poke2 == null)
            {
                aantalDraws++;
                return 0;
            }
            else
            {
                int AverageFS1 = (poke1.Defense_Full + poke1.HP_Full + poke1.Attack_Full + poke1.Speed_Full + poke1.SpecialAttack_Full + poke1.SpecialDefense_Full) / 6;
                int AverageFS2 = (poke2.Defense_Full + poke2.HP_Full + poke2.Attack_Full + poke2.Speed_Full + poke2.SpecialAttack_Full + poke2.SpecialDefense_Full) / 6;

                if (AverageFS1 > AverageFS2)
                {
                    return 1;
                }
                else if (AverageFS2 > AverageFS1)
                {
                    return 2;
                }
                else
                {
                    aantalDraws++;
                    return 0;
                }
            }
        }
        public static void Info()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nAantal battles: {aantalBattles}\nAantal draws: {aantalDraws}\nAantal random generated pokemons: {aantalRandomPokemons}\nAantal level ups: {aantalLevelUps}");
            Console.ResetColor();
        }
    }
}
