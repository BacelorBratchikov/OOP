using Model;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Adult partner = new Adult("ERER", "REEWR", 12, Gender.Female);
            partner.Name = "Test";

            Console.WriteLine(partner.GetInfo());
        }
    }
}
