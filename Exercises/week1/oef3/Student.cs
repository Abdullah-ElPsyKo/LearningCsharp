using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentenklasse
{
    public enum Klassen { TI1, TI2, TI3 }

    public class Student
    {

        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }
        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        private double BerekenTotaalCijfer() { return Math.Round(((PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech)/(double)3),1); }

        public void GeefOverzicht()
        {
            Console.WriteLine($"{Naam}, {Leeftijd} jaar\nKlas: {Klas}\n\nCijferrapport:\n*********\n");
            Console.WriteLine($"Communicatie:                       {PuntenCommunicatie}");
            Console.WriteLine($"Programming Principles:             {PuntenProgrammingPrinciples}");
            Console.WriteLine($"Web Technology:                     {PuntenWebTech}");
            Console.WriteLine($"Gemiddelde:                         {BerekenTotaalCijfer()}");
        }
    }
}