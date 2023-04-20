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
        private static void Main()
        {
            Console.WriteLine("Приветик, вот мы и встретились" +
               " на второй лабе) Нажми что-нибудь, чтобы продолжить.");
            _ = Console.ReadKey();

            Console.WriteLine("Молодец, нажимать на кнопки ты умеешь." +
                "Раз ты прошел этот тест, то теперь можешь посмотреть" +
                " как создаются рабочие люди и дети.");
            _ = Console.ReadKey();

            var personlist = new PersonList();

            for (int i = 0; i < 7; i++)
            {
                personlist.AddPerson
                    (GeneratorRandomPersons.GetRandomAnyPerson());
            }

            Console.WriteLine("Список людей:");
            PrintList(personlist);

            Console.WriteLine("\nНайдем четвертого человека и посмотрим, " +
                "как этот патирот служит своему отечеству\n");
            _ = Console.ReadKey();

            PersonBase person = personlist.FindPersonByIndex(3);

            switch (person)
            {
                case Adult adult:
                    {
                        Console.WriteLine($"Это взрослый рабочий: " +
                            $"{adult.Name} {adult.Surname}, " +
                            $"место работы: {adult.Job}");
                        break;
                    }

                case Child child:
                    {
                        Console.WriteLine($"Это ребенок рабочего: " +
                            $"{child.Name} {child.Surname}, " +
                            $"место учебы: {child.Institution}");
                        break;
                    }

                default:
                    break;
            }

            PersonBase newperson = InputPersonByConsole();

            Console.WriteLine("\nНоый челоечек: ");
            Console.WriteLine(newperson.GetInfo());
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
                            throw new ArgumentException(
                                "Введите для взрослого - 1, " +
                                "для ребёнка - 2: ");
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
                    Console.Write($"Товарищь, возраст: ");
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

                                Console.WriteLine("Так точно! " +
                                    "Вторую половинку мы сами найдем " +
                                    "тебе, товарищь!");

                                var randomPersonGender =
                                newpersonAdult.Gender == Gender.Male
                                    ? Gender.Female
                                    : Gender.Male;

                                newpersonAdult.Partner =
                                GeneratorRandomPersons.GetRandomAdult
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
                }), "Семейный статус")
            };

            var actionlistChild = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Child newpersonChild = (Child)person;
                    newpersonChild.Mother = CheckParents(
                        newpersonChild, "о матери", Gender.Female);

                }), "информационный запрос о наличии мамы"),
                (new Action(() =>
                {
                    Child newpersonChild = (Child)person;
                    newpersonChild.Father = CheckParents(
                        newpersonChild, "об отце", Gender.Male);

                }), "информационный запрос о наличии папы"),
                (new Action(() =>
                {
                    Child newpersonChild = (Child)person;
                    Console.Write($"Ребёнок институализируется? " +
                        $"(1 - да, 0 - нет)");
                    switch (ushort.Parse(Console.ReadLine()))
                    {
                        case 1:
                            {
                                if (newpersonChild.Age < 7)
                                {
                                    Console.Write("Введите наименование" +
                                        " детского сада: ");
                                    newpersonChild.Institution =
                                    "Детский сад \""
                                    + Console.ReadLine() + "\"";
                                }
                                else
                                {
                                    Console.Write("Введите наименование" +
                                        " школы: ");
                                    newpersonChild.Institution =
                                    "Школа \"" + Console.ReadLine() + "\"";
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

            // Выбор взрослого или ребёнка
            ActionHandler(actionStart, "Взрослый или ребенок");

            foreach (var action in actionList)
            {
                ActionHandler(action.Item1, action.Item2);
            }

            // Заполнение взрослого или ребёнка
            switch (person)
            {
                case Adult:
                    {
                        foreach (var action in actionlistAdult)
                        {
                            ActionHandler(action.Item1, action.Item2);
                        }

                        break;
                    }

                case Child:
                    {
                        foreach (var action in actionlistChild)
                        {
                            ActionHandler(action.Item1, action.Item2);
                        }

                        break;
                    }

                default:
                    break;
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
                    if (exception.GetType() == typeof(IndexOutOfRangeException)
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

        /// TODO(+): xml
        /// <summary>
        /// Метод создания родителей или их отсутствия.
        /// </summary>
        /// <param name="newChild">Новый ребенок.</param>
        /// <param name="parent">Родители.</param>
        /// <param name="gender">Пол родителя.</param>
        /// <returns>Родителя или его отсутсие.</returns>
        /// <exception cref="ArgumentException">Ошибка.</exception>
        private static Adult? CheckParents(Child newChild,
            string parent, Gender gender)
        {
            Console.Write($"У ребёнка есть информация {parent}?" +
                        " (1 - есть (будет поднята из архива), " +
                        "0 - нет информации):");
            ushort haveOrNot = ushort.Parse(Console.ReadLine());
            switch (haveOrNot)
            {
                case 1:
                    {
                        return gender == Gender.Male
                            ? GeneratorRandomPersons.GetRandomAdult
                                (MaritalStatus.Married,
                                newChild.Mother, gender)
                            : GeneratorRandomPersons.GetRandomAdult
                                (MaritalStatus.Married,
                                newChild.Father, gender);
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
