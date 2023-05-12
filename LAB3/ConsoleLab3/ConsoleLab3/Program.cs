namespace ConsoleLab3
{
    /// <summary>
    /// Основная консольная программа.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Основная пронрамма.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Давай провверим сколько калорий вы сожгли\n");
            while (true)
            {
                Console.Write("Найдем сколько сожгли калорий вы" +
                    " в результате упражнений - введите 1.\n" +
                    "Хотите закончить выполнение программы - введите 2." +
                    "\nВведите: ");
                bool isParsed = short.TryParse(Console.ReadLine(),
                            out short actionNumber);
                if (!isParsed)
                {
                    Console.WriteLine("1 или 2");
                }

                switch (actionNumber)
                {
                    case 1:
                        {
                            ConsoleClass.AddWorkout();
                            break;
                        }

                    case 2:
                        {
                            return;
                        }

                    default:
                        {
                            Console.WriteLine("Введите число 1 или 2!");
                            break;
                        }
                }
            }
        }
    }
}
