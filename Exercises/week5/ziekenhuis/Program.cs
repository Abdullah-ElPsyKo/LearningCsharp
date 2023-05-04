namespace ziekenhuis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VerzekerdePatient patient = new VerzekerdePatient();

            patient.naam = "abdullah";
            patient.aantalUurSick = 6;

            patient.ToonInfo();
        }
    }
}