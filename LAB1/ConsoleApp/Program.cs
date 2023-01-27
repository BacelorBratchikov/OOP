using Model;


namespace ConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Основная функция, которая создает Персон
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person(string.Empty, "Ivanov", 20, Gender.Male);
            }

            catch (ArgumentException exeption)
            {
                if (exeption.GetType() == typeof(ArgumentNullException)
                    || exeption.GetType() == typeof(ArgumentException))
                {
                    Console.WriteLine(exeption.Message);
                }
            }

            Person partner = new Person("Anastasia", "Kuznetsova", 19, Gender.Female);

            Console.ReadKey();
        }
    }
}