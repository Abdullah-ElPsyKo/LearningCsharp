using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figures
{
    public abstract class GeometricFigure
    {
        public double Height { get; set; }
        public double Width { get; set; }

        private double oppervlakte;

        public double Oppervlakte
        {
            get { return BerekenOppervlakte(); }
        }

        public abstract double BerekenOppervlakte();

    }

    public class Rechthoek : GeometricFigure
    {
        public override double BerekenOppervlakte()
        {
            double opp = Height * Width;
            return opp;
        }
    }

    public class Vierkant : Rechthoek
    {
        public Vierkant(double h, double w)
        {
            if (h != w)
            {
                h = w;
            }
            Height = h;
            Width = w;
        }
        public Vierkant(double l)
        {
            Height = Width = l;
        }
    }
    public class Driehoek : GeometricFigure
    {
        public override double BerekenOppervlakte()
        {
            double opp = Height * Width / 2;
            return opp;
        }
    }
}
