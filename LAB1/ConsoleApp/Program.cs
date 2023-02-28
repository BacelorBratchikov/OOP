//using Model;

namespace ConsoleApp
{
    /// <summary>
    /// Основной класс.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Параметры.</param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Hellow World");
            /*
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
            GeneratorRandomPersons genRandPerson = new GeneratorRandomPersons();

            var randPerson = genRandPerson.GetRandomPerson();
            Console.WriteLine(randPerson.ToString);
            //Console.ReadKey();
            */
        }
    }
}
