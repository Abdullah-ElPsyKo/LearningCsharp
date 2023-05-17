using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord_Dams_Van_Camp_editie
{
    public class Dobbelsteen
    {
        static public int Rol()
        {
            Random rangen = new Random();
            int getal = rangen.Next(1, 4);
            return getal;
        }
    }
    public class Speelvakje
    {
        public int BeweegVakjes { get; private set; }
        public Speelvakje()
        {
            Random rangen = new Random();
            int kansen = rangen.Next(1, 101);
            if (kansen < 51)
            {
                BeweegVakjes = 0;
            }
            else if (kansen > 50 && kansen < 81)
            {
                kansen = rangen.Next(1, 101);
                if (kansen < 51)
                {
                    BeweegVakjes = 1;
                }
                else
                {
                    BeweegVakjes = 2;
                }
            }
            else
            {
                kansen = rangen.Next(1, 101);
                if (kansen < 51)
                {
                    BeweegVakjes = -1;
                }
                else
                {
                    BeweegVakjes = -2;
                }
            }
        }
        virtual public void ToonVakje()
        {
            if (BeweegVakjes >= 0)
            {
                Console.Write("+" + BeweegVakjes);
            }
            else
            {
                Console.Write(BeweegVakjes);
            }
        }

    }
    public class Ganzenbord
    {
        private List<Speelvakje> SpeelVakjes = new List<Speelvakje>();
        Speelvakje toonVak;
        public Ganzenbord(bool kleurBool)
        {
            if (kleurBool == true)
            {
                for (int i = 0; i < 10; i++)
                {

                    SpeelVakjes.Add(new KleurVakje());
                } 
            }
        }
        public Ganzenbord()
        {
            for (int i = 0; i < 10; i++)
            {

                SpeelVakjes.Add(new Speelvakje());
            }
        }
        public int pionIndex;
        public int HuidigeScore { get; set; } = 0;

        public bool BeweegPion(int a)
        {
            pionIndex += a;
            if (pionIndex > 9)
            {
                HuidigeScore += 10;
                return true;
            }
            else
            { 
                pionIndex += SpeelVakjes[pionIndex].BeweegVakjes;
                Console.WriteLine(pionIndex);

                if (pionIndex <= 8 && pionIndex >= 0)
                {
                    return false;
                }
                else if (pionIndex > 8)
                {
                    return true;
                }
                else
                {
                    HuidigeScore -= 10;
                    pionIndex = 0; //reset
                    return false;
                }
            }
        }
        public void TekenBord()
        {
            for (int i = 0; i < SpeelVakjes.Count; i++)
            {
                if (pionIndex == i)
                {
                    if (SpeelVakjes[i].BeweegVakjes < 0)
                    {
                        Console.Write("-T");
                    }
                    else
                    {
                        Console.Write("+T");
                    }
                    
                }
                else
                {
                    SpeelVakjes[i].ToonVakje();
                }
            }
        }
    }
    public class KleurVakje : Speelvakje
    {
        public KleurVakje() : base()
        {
            
        }
        public override void ToonVakje()
        {
            if (base.BeweegVakjes < 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(BeweegVakjes);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("+" + BeweegVakjes);
            }
            Console.ResetColor();
        }
    }
}
