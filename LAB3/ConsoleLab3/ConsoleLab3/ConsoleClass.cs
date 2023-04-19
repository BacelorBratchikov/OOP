using Model;
using Model.Exercises;

namespace ConsoleLab3
{
    /// <summary>
    /// Класс в котором содержатся основные консольные действия с классами.
    /// </summary>
    internal class ConsoleClass
    {
        /// <summary>
        /// Метод проверки ввода числа.
        /// </summary>
        /// <param name="number">Число.</param>
        /// <returns>Обработанное число.</returns>
        /// <exception cref="ArgumentException">Ошибка.</exception>
        private static double CheckNumber(string number)
        {
            if (number.Contains('.'))
            {
                number = number.Replace('.', ',');
            }

            bool isParsed = double.TryParse(number,
                        out double checkNumber);

            if (!isParsed)
            {
                throw new ArgumentException("Введите число!");
            }

            return checkNumber;
        }

        /// <summary>
        /// Метод добавления упражнений.
        /// </summary>
        /// <exception cref="ArgumentException">Ошибка.</exception>
        public static void AddWorkout()
        {
            IСaloriesable exercise = new Running();

            Action actionStart = new Action(() =>
            {

                Console.Write($"1 - бег,\n" +
                    $"2 - плавание,\n3 - жим лежа." +
                    $"\nРасчёт сожженых калорий:");

                bool _ = int.TryParse(Console.ReadLine(), out int workout);

                switch (workout)
                {
                    case 1:
                        {
                            exercise = new Running();
                            break;
                        }

                    case 2:
                        {
                            exercise = new Swimming();
                            break;
                        }

                    case 3:
                        {
                            exercise = new BarbellPress();
                            break;
                        }

                    default:
                        {
                            throw new ArgumentException
                            ("Введите корректный номер упражнения.");
                        }
                }
            });

            var actionRunning = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите преодаленную дистанцию в км: ");
                    Running running = (Running)exercise;
                    running.Distance = CheckNumber(Console.ReadLine());

                }), "преодаленная дистанция"),
                (new Action(() =>
                {
                    Console.Write($"Введите скорость бега в км/ч: ");
                    Running running = (Running)exercise;
                    running.Speed = CheckNumber(Console.ReadLine());
                }), "скорость бега"),
                (new Action(() =>
                {
                    Running running = (Running)exercise;
                    Console.WriteLine($"Рассчет калорий в ккал: " +
                        $"{Math.Round(exercise.CalculationCalories(), 3)}\n");
                    _ = Console.ReadKey();
                }), "количество калорий")
            };

            var actionSwimming = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите преодаленную дистанцию в км: ");
                    Swimming swimming = (Swimming)exercise;
                    swimming.Distance = CheckNumber(Console.ReadLine());

                }), "преодаленная дистанция"),
                (new Action(() =>
                {
                    Swimming swimming = (Swimming)exercise;
                    Console.Write
                        ($"Введи стиль плавания: 1 - Брас, 2 - Кроль," +
                        $" 3 - Батерфляй, 4 - На спине)): ");
                    _ = int.TryParse(Console.ReadLine(),

                        out int tmpTypeSwimming);
                    if (tmpTypeSwimming < 1 || tmpTypeSwimming > 4)
                    {
                        throw new IndexOutOfRangeException
                            ("Не изобретай новые стили. Плыви как надо." +
                            " Введи: 1 - Брас, 2 - Кроль, 3 - Батерфляй, " +
                            "4 - На спине");
                    }

                    TypesOfSwimming realTypeSwimming;

                    switch (tmpTypeSwimming)
                    {
                        case 1:
                            realTypeSwimming = TypesOfSwimming.Breaststroke;
                            break;
                        case 2:
                            realTypeSwimming = TypesOfSwimming.Crawl;
                            break;
                        case 3:
                            realTypeSwimming = TypesOfSwimming.Butterfly;
                            break;
                        default:
                            realTypeSwimming = TypesOfSwimming.OnTheBack;
                            break;
                    }

                    swimming.SwimmingType = realTypeSwimming;
                }), "стиль плавания"),
                (new Action(() =>
                {
                    Console.WriteLine($"Рассчет калорий в ккал: " +
                        $"{Math.Round(exercise.CalculationCalories(), 3)}\n");
                    _ = Console.ReadKey();
                }), "количество калорий")
            };

            var actionBarbellPress = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите количество повторений: ");
                    BarbellPress barbellPress = (BarbellPress)exercise;
                    _ = int.TryParse(Console.ReadLine(),
                        out int tmpBarbellPress);
                    barbellPress.Repetitions = tmpBarbellPress;
                }), "количество повторений"),
                (new Action(() =>
                {
                    Console.Write($"Поднимаемый вес в кг: ");
                    BarbellPress barbellPress = (BarbellPress)exercise;
                    barbellPress.Weight = CheckNumber(Console.ReadLine());
                }), "поднимаемый вес"),
                (new Action(() =>
                {
                    BarbellPress barbellPress = (BarbellPress)exercise;
                    Console.WriteLine($"Рассчет калорий в ккал: " +
                        $"{Math.Round(exercise.CalculationCalories(), 3)}\n");
                    _ = Console.ReadKey();
                }), "количество калорий")
            };

            ActionHandler(actionStart, "номер упражнений");

            var exerciseActionDictionary =
                new Dictionary<Type, List<(Action, string)>>
            {
                {typeof(Running), actionRunning },
                {typeof(Swimming), actionSwimming },
                {typeof(BarbellPress), actionBarbellPress },
            };

            foreach (var action in
                exerciseActionDictionary[exercise.GetType()])
            {
                ActionHandler(action.Item1, action.Item2);
            }
        }

        /// <summary>
        /// Метод использования Action.
        /// </summary>
        /// <param name="action">Действие.</param>
        /// <param name="propertyName">Дополнительные параметры.</param>
        private static void ActionHandler(Action action, string propertyName)
        {

            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (ArgumentException exception)
                {
                    if (exception.GetType()
                        == typeof(IndexOutOfRangeException)
                        || exception.GetType() == typeof(ArgumentException))
                    {
                        Console.WriteLine($"Некорректный введен(о) " +
                        $"{propertyName}. Ошибка: {exception.Message}" +
                        $" Пробуй ввести {propertyName} еще раз.");
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }
        }
    }
}
