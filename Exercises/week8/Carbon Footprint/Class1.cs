using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbon_Footprint
{
    internal class Class1
    {
        public interface ICarbonFootPrint
        {
            double BerekenFootprint();
            void VerlaagFootprint();
        }
        public class Huis : ICarbonFootPrint
        {
            public int volume { get; set; } //carbonfootprint based on volume
            private int footprintMp = 10;
            public double BerekenFootprint()
            {
                return volume * footprintMp;
            }
            public void VerlaagFootprint()
            {
                footprintMp -= 1;
            }
        }
        public class Fabriek : ICarbonFootPrint
        {
            public int aantalWerknemers { get; set; } //carbonfootprint based on amount of workers
            private int workersEfficiency = 100; //default is 100
            public double BerekenFootprint()
            {
                return aantalWerknemers * workersEfficiency;
            }
            public void VerlaagFootprint()
            {
                workersEfficiency -= 1;
            }
        }
        public class Auto : ICarbonFootPrint
        {
            public string merkAuto { get; set; } //carbonfootprint based on what car
            string[] autoMerken = {"bmw", "mercedes", "audi", "volkswagen"};
            double[] carbonFootprints = { 2.5, 3.0, 2.8, 2.2 };

            public double BerekenFootprint()
            {
                for (int i = 0; i < autoMerken.Length; i++)
                {
                    if (merkAuto == autoMerken[i])
                    {
                        return carbonFootprints[i];
                    }
                }
                return 0.0;
            }
            public void VerlaagFootprint()
            {
                for (int i = 0; i < autoMerken.Length; i++)
                {
                    if (merkAuto == autoMerken[i])
                    {
                        carbonFootprints[i] -= 0.2; //car got more efficient somehow
                    }
                }
            }
        }
        public class Plant
        {
        }
    }
}
