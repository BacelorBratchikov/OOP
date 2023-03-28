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
                    Console.Write(
                            personList.FindPersonByIndex(i).GetInfo());
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
        public static PersonBase InputPersonByConsole()
        {
            PersonBase person = new Adult();

            Action actionStart = new Action(() =>
            {
                Console.Write($"Если хотите ввести взрослого напишите: 1," +
                                  $" если ребёнка: 2\tВвод:");

                int whoIsThis = int.Parse(Console.ReadLine());

                switch (whoIsThis)
                {
                    case 1:
                        {
                            person = new Adult();
                            break;
                        }

                    case 2:
                        {
                            person = new Child();
                            break;
                        }

                    default:
                        {
                            throw new ArgumentException("Введите для взрослого - 1, для ребёнка - 2: ");
                        }
                }
            });

            var actionList = new List<(Action, string)>
            {
                (
                new Action(() =>
                {
                    Console.Write($"Введи имя работяги: ");
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
                        ($"Введи пол настоящего труженика:" +
                        $" (1 - Мужской or 2 - Женский): ");
                    _ = int.TryParse(Console.ReadLine(), out int tmpGender);
                    if (tmpGender < 1 || tmpGender > 2)
                    {
                        throw new IndexOutOfRangeException
                            ("Тебе стоит пересмотреть свои убеждения" +
                    " существует только мужской пол - 1 и женский - 2!");
                    }

                    var realGender = tmpGender == 1
                        ? Gender.Male
                        : Gender.Female;
                    person.Gender = realGender;
                }), "пол")
            };

            // Действия для взрослого.
            var actionlistAdult = new List<(Action, string)>
            {
                // Паспорт.
                (new Action(() =>
                {
                    Console.Write($"Введите номер паспорта (10 цифр):");
                    bool result = uint.TryParse(Console.ReadLine(),
                        out uint passport);
                    Adult newpersonAdult = (Adult)person;

                    if(result != true)
                    {
                        throw new ArgumentException("Номер паспорта введён некорректно," +
                            " вводите только цифры!");
                    }

                    newpersonAdult.Рassport = passport;
                }), "Паспорт"),

                // Место работы.
                (new Action(() =>
                {
                    Adult newpersonAdult = (Adult)person;
                    Console.Write("Введите место работы: ");
                    newpersonAdult.Job = Console.ReadLine();
                }), "Работа"),

                // Семейное положение.
                (new Action(() =>
                {
                    Adult newpersonAdult = (Adult)person;
                    Console.Write($"Семейное положение " +
                        $"(0 - одиночка по жизни, 1 - состоит в браке): ");
                    ushort maritalstatus1 = ushort.Parse(Console.ReadLine());
                    switch (maritalstatus1)
                    {
                        case 1:
                            {
                                newpersonAdult.StatusAdualt =
                                MaritalStatus.Married;

                                Console.WriteLine("Каждой твари по паре!");
                                _ = Console.ReadKey();

                                var randomPersonGender =
                                newpersonAdult.Gender == Gender.Male
                                    ? Gender.Female
                                    : Gender.Male;

                                newpersonAdult.Partner =
                                RandomPerson.GetRandomAdult
                                (MaritalStatus.Married,
                                newpersonAdult, randomPersonGender);

                                break;
                            }

                        case 0:
                            {
                                newpersonAdult.StatusAdualt =
                                MaritalStatus.SingleWolf;
                                break;
                            }

                        default:
                            {
                                throw new ArgumentException
                                    ("Вводи 1 и не думай! " +
                                    "Просто создавай семью.");
                            }
                    }
                }), "maritalstatus")
            };

            // Действия для ребенка.
            var actionlistChild = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Child newpersonChild = (Child)person;
                    newpersonChild.Mother = CheckParents(newpersonChild, "о матери", Gender.Female);

                }), "Мама"),
                (new Action(() =>
                {
                    Child newpersonChild = (Child)person;
                    newpersonChild.Father = CheckParents(newpersonChild, "об отце", Gender.Male);

                }), "Отец"),
                (new Action(() =>
                {
                    Child newpersonChild = (Child)person;
                    Console.Write($"Ребёнок институализируется? (1 - да, 0 - нет)");
                    switch (ushort.Parse(Console.ReadLine()))
                    {
                        case 1:
                            {
                                if (newpersonChild.Age < 7)
                                {
                                    Console.Write("Введите наименование детского сада: ");
                                    newpersonChild.Institution = "Детский сад \"" + Console.ReadLine() + "\"";
                                }
                                else
                                {
                                    Console.Write("Введите наименование школы: ");
                                    newpersonChild.Institution = "Школа \"" + Console.ReadLine() + "\"";
                                }

                                break;
                            }

                        case 0:
                            {
                                break;
                            }

                        default:
                            {
                                throw new ArgumentException
                                ("Введите 1, пусть внедряется в общество!");
                            }
                    }
                }), "Институт")

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

        /// <summary>
        /// Метод ввода родителей.
        /// </summary>
        /// <param name="newChild">Ребеночек.</param>
        /// <param name="parent">Родители.</param>
        /// <exception cref="ArgumentException">Ошибка.</exception>
        private static Adult? CheckParents(Child newChild, string parent, Gender gender)
        {
            Console.Write($"У ребёнка есть информация {parent}?" +
                        " (1 - есть (будет поднята из архива), 0 - нет информации):");
            ushort haveOrNot = ushort.Parse(Console.ReadLine());
            switch (haveOrNot)
            {
                case 1:
                    {
                        return gender == Gender.Male
                            ? RandomPerson.GetRandomAdult
                        (MaritalStatus.Married, newChild.Mother, gender)
                            : RandomPerson.GetRandomAdult
                        (MaritalStatus.Married, newChild.Father, gender);
                    }

                case 0:
                    {
                        return null;
                    }

                default:
                    {
                        throw new ArgumentException
                        ($"Введите 1 - есть информация {parent}," +
                        " 0 - нет информации.");
                    }
            }
        }
    }
}
