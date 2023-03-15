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
            Console.WriteLine("Привет! Это первая лабораторная работа по" +
                " ООП. Здесь создаются и удаляются персоны. Не удивляйся" +
                " персонам и их именам. Это просто люди для лабораторной.");
            Console.WriteLine("Нажми на кнопку чтобы начать приключение!\n");
            _ = Console.ReadKey();

            Console.WriteLine("Шаг 1. Создание двух списиков.\n");
            _ = Console.ReadKey();

            var listOne = new PersonList();
            var listTwo = new PersonList();

            var collectionOne = new Person[]
            {
                new Person("Магистр", "Йода", 900, Gender.Male),
                new Person("Энакин", "Скайуокер", 43, Gender.Male),
                new Person("Оби-Ван", "Кеноби", 57, Gender.Male),
            };

            var collectionTwo = new Person[]
            {
                new Person("Дарт", "Тиранус", 83, Gender.Male),
                new Person("Дарт", "Сидиус", 86, Gender.Male),
                new Person("Дарт", "Мол", 35, Gender.Male),
            };

            listOne.AddRangeInList(collectionOne);
            listTwo.AddRangeInList(collectionTwo);

            Console.WriteLine("Два списка персон созданы, хочешь " +
                "посмотреть кого ты создал? Нажми на кнопку! (шаг 2)");
            _ = Console.ReadKey();

            Console.WriteLine("\nПервый созданный список (Орден джедаев):");
            PrintList(listOne);

            Console.WriteLine("\nВторой созданный список (Орден ситхов):");
            PrintList(listTwo);

            Console.WriteLine(listOne.FindPersonByIndex(1).GetInfo());

            Console.WriteLine("Шаг 3. Создание рандомной персоны");
            _ = Console.ReadKey();

            Person randomPerson = GeneratorRandomPersons.GetRandomPerson();
            Console.WriteLine(randomPerson.GetInfo());

            Console.WriteLine("Теперь добавляем персону в первый спсиок");
            listOne.AddPerson(randomPerson);

            Console.WriteLine("\nОрден джедаев:");
            PrintList(listOne);

            Console.WriteLine("Шаг 4. Скопируем вторую персону " +
                "из первого списка в конец второго спсика.");
            _ = Console.ReadKey();
            listTwo.AddPerson(listOne.FindPersonByIndex(1));

            Console.WriteLine("\nОрден джедаев:");
            PrintList(listOne);

            Console.WriteLine("\nОрден ситхов:");
            PrintList(listTwo);

            Console.WriteLine("Шаг 5. Удалим второго человека " +
                "из первого спсика.");
            _ = Console.ReadKey();

            Console.WriteLine("Энакин, ты должен был бороться " +
                "со злом, а не примкнуть к нему!");
            _ = Console.ReadKey();

            listOne.DeleteByIndex(1);

            Console.WriteLine("\nОрден джедаев:");
            PrintList(listOne);

            Console.WriteLine("\nОрден ситхов:");
            PrintList(listTwo);

            Console.WriteLine("Шаг 6. Очистим первый спсиок.");
            _ = Console.ReadKey();

            Console.WriteLine("Палпатин: \"Власть ситхов вновь " +
                "воцарится над галлактикой. И везде снова настанет " +
                "мир. Вот время и настало. Выполнить приказ 66!\"");
            _ = Console.ReadKey();

            listTwo.ClearPerson();

            Console.WriteLine("\nОрден джедаев:");
            PrintList(listTwo);

            Console.WriteLine("Орден Джедаев уничтожен!");

            Console.WriteLine("Настало время новой надежды, " +
                "которую создашь именно ты!");
            _ = Console.ReadKey();

            var inputPerson = InputPersonByConsole();
            Console.WriteLine(inputPerson.GetInfo());
        }

        /// <summary>
        /// Метод предназначен для вывода всех перосн из списка в консоль.
        /// </summary>
        /// <param name="personList">Спсиок персон.</param>
        /// <exception cref="NullReferenceException">
        /// Не существует спсика.</exception>
        private static void PrintList(PersonList personList)
        {
            if (personList == null)
            {
                throw new NullReferenceException("Списка не существует.");
            }

            if (personList.CountByPerson() != 0)
            {
                for (int i = 0; i < personList.CountByPerson(); i++)
                {
                    var tmpPerson = personList.FindPersonByIndex(i);
                    Console.Write(tmpPerson.GetInfo());
                }
            }
            else
            {
                Console.WriteLine("Список пустой.");
            }
        }

        /// <summary>
        /// Метод позволяющий вводить персону с консоли.
        /// </summary>
        /// <returns>Введеная персона.</returns>
        /// <exception cref="ArgumentException">Ошибочки.</exception>
        public static Person InputPersonByConsole()
        {
            var person = new Person();

            var actionList = new List<(Action, string)>
            {
                (
                new Action(() =>
                {
                    Console.Write($"Введи имя наделенного силой: ");
                    person.Name = Console.ReadLine();
                }), "Имя"),

                (new Action(() =>
                {
                    Console.Write($"Так, а теперь его фамилию: ");
                    person.Surname = Console.ReadLine();
                }), "Фамилия"),

                (new Action(() =>
                {
                    Console.Write($"Твой возраст: ");
                    _ = int.TryParse(Console.ReadLine(), out int tmpAge);
                    person.Age = tmpAge;
                }), "возраст"),

                (new Action(() =>
                {
                    Console.Write
                        ($"Введи пол обладателя силы:" +
                        $" (1 - Мужской or 2 - Женский): ");
                    _ = int.TryParse(Console.ReadLine(), out int tmpGender);
                    if (tmpGender < 1 || tmpGender > 2)
                    {
                        throw new IndexOutOfRangeException
                            ("Тебе стоит пересмотреть свои убеждения" +
                    " существует только мужской пол - 1и женский - 2!");
                    }

                    var realGender = tmpGender == 1
                        ? Gender.Male
                        : Gender.Female;
                    person.Gender = realGender;
                }), "пол")
            };

            foreach (var action in actionList)
            {
                ActionHandler(action.Item1, action.Item2);
            }

            return person;
        }

        /// <summary>
        /// Метод обрабатывает твои действия.
        /// </summary>
        /// <param name="action">Содержит действие.</param>
        /// <param name="propertyName">Дополнительные параметры.</param>
        private static void ActionHandler(Action action, string propertyName)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    break;
                }
                catch (Exception exception)
                {
                    if (exception.GetType()
                        == typeof(IndexOutOfRangeException)
                        || exception.GetType() == typeof(FormatException)
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
