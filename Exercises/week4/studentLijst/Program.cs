using studentLijst;
using System;
using System.Diagnostics;

namespace studentLijst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> Lijst = new List<Student>();

            for (int i = 0; i < 5; i++)
            {
                Student newStudent = new Student();
                Lijst.Add(newStudent);
            }

            Console.WriteLine("Keuze:\n1: Student gegevens invoeren\n2. Student gegevens tonen");
            int keuze = int.Parse(Console.ReadLine());
            int nrLeerling = 0;
            if (keuze == 1)
            {
                foreach (Student item in Lijst)
                {
                    nrLeerling++;
                    Console.WriteLine($"Voer de gegevens in van student {nrLeerling}: ");

                    Console.WriteLine("Naam: ");
                    string naam = Console.ReadLine();
                    item.Naam = naam;

                    Console.WriteLine("Leeftijd: ");
                    int Leeftijd = int.Parse(Console.ReadLine());
                    item.Leeftijd = Leeftijd;

                    Console.WriteLine("Klas: ");
                    Klassen myEnum = (Klassen)Enum.Parse(typeof(Klassen), Console.ReadLine());
                    item.Klas = myEnum;

                    Console.WriteLine("PuntenCommunicatie: ");
                    int PuntenCommunicatie = int.Parse(Console.ReadLine());
                    item.PuntenCommunicatie = PuntenCommunicatie;

                    Console.WriteLine("PuntenProgrammingPrinciples: ");
                    int PuntenProgrammingPrinciples = int.Parse(Console.ReadLine());
                    item.PuntenProgrammingPrinciples = PuntenProgrammingPrinciples;

                    Console.WriteLine("PuntenWebTech: ");
                    int PuntenWebTech = int.Parse(Console.ReadLine());
                    item.PuntenWebTech = PuntenWebTech;

                    item.GeefOverzicht();
                }
            }
            else
            {
                foreach (var item in Lijst)
                {
                    item.GeefOverzicht();
                }
            } 
        }
    }
}


