using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentLijst
{
    enum Klassen { EA1, EA2, EA3, EA4, GeenKlas }

    class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }

        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        public Student()
        {
            Naam = "geenNaamIngegeven";
            Leeftijd = 0;
            Klas = Klassen.GeenKlas;
    
            PuntenCommunicatie = 0;
            PuntenProgrammingPrinciples = 0;
            PuntenWebTech = 0;
        }

        public double BerekenTotaalCijfer()
        {
            return (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0;
        }

        public void GeefOverzicht()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\n{Naam}, {Leeftijd} jaar");
            Console.WriteLine($"Klas: {Klas}");
            Console.ResetColor();
            Console.WriteLine("Cijferrapport");
            Console.WriteLine("*************");
            Console.WriteLine($"Communicatie:\t\t{PuntenCommunicatie}");
            Console.WriteLine($"Programming Principles:\t{PuntenProgrammingPrinciples}");
            Console.WriteLine($"Web Technology:\t\t{PuntenWebTech}");
            Console.WriteLine($"Gemiddelde:\t\t{BerekenTotaalCijfer():0.0}");
        }
    }
}
