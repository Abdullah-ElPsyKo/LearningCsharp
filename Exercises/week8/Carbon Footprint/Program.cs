using static Carbon_Footprint.Class1;

namespace Carbon_Footprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> vervuilers = new List<object>();
            vervuilers.Add(new Plant());
            vervuilers.Add(new Huis() { volume = 200 });
            vervuilers.Add(new Fabriek() { aantalWerknemers = 10 });
            vervuilers.Add(new Auto() { merkAuto = "audi" });
            vervuilers.Add(new Plant());
            vervuilers.Add(new Huis() { volume = 100 });
            vervuilers.Add(new Fabriek() { aantalWerknemers = 25 });
            vervuilers.Add(new Auto() { merkAuto = "bmw" });

            double carbonfootprint = 0;
            double grootsteVervuiling = 0;
            int grootsteVervuilerIndex = 0;

            for (int i = 0; i < vervuilers.Count; i++)
            {

                var vervuilverI = vervuilers[i] as ICarbonFootPrint;
                if (vervuilverI != null)
                {
                    vervuilverI.VerlaagFootprint(); //carbon footprint lowered on all objects
                    double vervuiling = vervuilverI.BerekenFootprint();
                    Console.WriteLine($"{vervuilers[i].GetType()}:{vervuiling}");
                    carbonfootprint += vervuiling;
                    if (vervuiling > grootsteVervuiling)
                    {
                        grootsteVervuiling = vervuiling;
                        grootsteVervuilerIndex = i;
                    }
                }
                else
                {
                    carbonfootprint -= 0.005; //let's say one plant processes 5kg of carbon a year

                }
            }
            Console.WriteLine($"\nGemiddelde footprint van alle objecten: {carbonfootprint / vervuilers.Count}.\nGrootste footprint: {grootsteVervuiling} door {vervuilers[grootsteVervuilerIndex].GetType()}");
            if (grootsteVervuilerIndex >= 0)
            {

            }
        }
    }
}