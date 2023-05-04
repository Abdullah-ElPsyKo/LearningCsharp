using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Boek
{
    public class Boek
    {
        public long ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        // make a full property for the price double
        private double price;
        public virtual double Price
        {
            get { return price; }
            set { price = value; }
        }

        // write a static method TelOp which takes 2 boek objects and returns a new boek object.
        public static Boek TelOp(Boek boek1, Boek boek2)
        {
            Boek boek3 = new Boek();

            boek3.Title = $"Omnibus van {boek1.Author}, {boek2.Author}."; //De titel wordt dan "Omnibus van X". waarbij X de Auteurs bevat, gescheiden met een komma.
            boek3.price = (boek1.price + boek2.price) / 2.0;

            return boek3;
        }
        public override string ToString()
        {
            //"Title - Auteur (ISBN) _ Prijs" (bv The Shining - Stephen King (05848152) _ 50)
            return $"{Title} - {Author} ({ISBN}) _ {price} euro";
        }
    }
    //In beide child-klassen, override de Prijs-setter zodat: a) Bij TextBoek de prijs enkel tussen 20 en 80 kan liggen b) Bij KoffietafelBoek de prijs enkel tussen 35 en 100 kan liggen
    public class TextBoek : Boek
    {
        public int GradeLevel { get; set; }
        public override double Price
        {
            get { return base.Price; }
            set
            {
                if (value >= 20 && value <= 80)
                {
                    base.Price = value;
                }
            }
        }
    }
    public class KoffietafelBoek : Boek
    {
        // ovveride price property, the price can only range from 35 to 100
        public override double Price
        {
            get { return base.Price; }
            set
            {
                if (value >= 35 && value <= 100)
                {
                    base.Price = value;
                }
            }
        }
    }
    
}
