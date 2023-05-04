
namespace Boek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boek boek1 = new TextBoek();
            boek1.Title = "Hello";
            boek1.Author = "Abdullah";
            boek1.Price= 60;
            boek1.ISBN = 123456789;

            Console.WriteLine(boek1);
            Boek boek2 = new KoffietafelBoek();
            boek2.Title = "Bye";
            boek2.Author = "hoihoi";
            boek2.Price = 71;
            boek2.ISBN = 098765432;

            Console.WriteLine(boek2);

            Boek boek3 = Boek.TelOp(boek1, boek2);
            Console.WriteLine(boek3);
        }
    }
}