using Model;

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
            Console.WriteLine(@"Press any key to start...\n");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine(@"Step 1. Two lists of persons are creating, " +
                "each contains three persons...\n");
            Console.WriteLine();
            Console.ReadKey();

            var listOne = new PersonList();
            var listTwo = new PersonList();

            var arrayOne = new Person[]
            {
                new Person("q", "w", 40, Gender.Male),
                new Person("e", "Fry", 28, Gender.Male),
                new Person("Sw", "w", 10, Gender.Female),
            };

            var arrayTwo = new Person[]
            {
                new Person("e", "r", 12, Gender.Male),
                new Person("q", "q", 11, Gender.Male),
                new Person("w", "w", 50, Gender.Male),
            };

            listOne.AddArrayOfPeople(arrayOne);
            listTwo.AddArrayOfPeople(arrayTwo);
        }
    }
}
