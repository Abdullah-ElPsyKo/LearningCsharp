namespace oef4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BibBoek test1 = new BibBoek();
            test1.Ontlener = "abdullah";
            test1.VerlengTermijn(3);
            Console.WriteLine(test1.InLeverDatum);
        }
    }
}