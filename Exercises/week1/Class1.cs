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
        public enum Klassen { TI1, TI2, TI3 }

        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }
        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        private double BerekenTotaalCijfer() { return (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech); }

        public int GeefOverzicht()
        {
            Console.WriteLine("haha");
        }
    }
}