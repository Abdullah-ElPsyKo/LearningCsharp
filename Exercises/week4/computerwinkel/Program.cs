namespace computerwinkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Computeronderdeel> lijst = new List <Computeronderdeel> ();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Alle computeronderdelen in de lijst: \n");
            Console.ResetColor();

            for (int i = 0; i < 100; i++)
            {
                Computeronderdeel nieuwonderdeel= new Computeronderdeel ();
                lijst.Add(nieuwonderdeel);
                nieuwonderdeel.ToonInfo();
            }

            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("\nAlle computeronderdelen met een prijs boven de 400: \n");
            Console.ResetColor();

            foreach (var item in lijst)
            {
                if (item.Prijs > 400)
                {
                    item.ToonInfo();
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nNu tonen we alle onderdelen in een doos: \n");
            Console.ResetColor();

            foreach (var item in lijst)
            {
                if (item.InDoos == true)
                {
                    item.ToonInfo();
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nNu tonen we alle onderdelen in een doos: \n");
            Console.ResetColor();

            foreach (var item in lijst)
            {
                if (item.ID % 2 == 0 && item.Prijs < 200)
                {
                    item.ToonInfo();
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nWat moet er met de lijst gebeuren?: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n1. Alle objecten in een doos verwijderen\n2. Alle objecten met een prijs kleiner dan 100 verwijderen.\n");
            Console.ResetColor();

            int manageChoice = int.Parse(Console.ReadLine());

            for (int i = 0; i < lijst.Count; i++)
            {
                if (manageChoice == 1)
                {
                    if (lijst[i].InDoos == true)
                    {
                        lijst.Remove(lijst[i]);
                    }
                    else
                    {
                        lijst[i].ToonInfo();
                    }
                }
                else if (manageChoice == 2)
                {
                    if (lijst[i].Prijs < 100)
                    {
                        lijst.Remove(lijst[i]);
                    }
                    else
                    {
                        lijst[i].ToonInfo();
                    }
                }
            }
        }
    }
}