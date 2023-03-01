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
                new Person("Иван", "Романов", 40, Gender.Male),
                new Person("Петр", "Романов", 28, Gender.Male),
                new Person("Анна", "Ионовна", 30, Gender.Female),
            };

            var collectionTwo = new Person[]
            {
                new Person("Билл", "Харрингтон", 49, Gender.Male),
                new Person("Ван", "Даркхолм", 48, Gender.Male),
                new Person("Рикардо", "Милос", 35, Gender.Male),
            };

            listOne.AddRangeInList(collectionOne);
            listTwo.AddRangeInList(collectionTwo);

            Console.WriteLine("Два списка персон созданы, хочешь " +
                "посмотреть кого ты создал? Нажми на кнопку! (шаг 2)");
            _ = Console.ReadKey();

            Console.WriteLine("\nПервый созданный список:");
            PrintList(listOne);

            Console.WriteLine("\nВторой созданный список:");
            PrintList(listTwo);
            
            Console.WriteLine("Шаг 3. Создание рандомной персоны");
            _ = Console.ReadKey();

            Person randomPerson = GeneratorRandomPersons.GetRandomPerson();
            Console.WriteLine(randomPerson.GetInfo());

            Console.WriteLine("Теперь добавляем персону в первый спсиок");
            listOne.AddPerson(randomPerson);

            Console.WriteLine("\nПервый список:");
            PrintList(listOne);

            Console.WriteLine("Шаг 4. Скопируем вторую персону " +
                "из первого списка в конец второго спсика.");
            _ = Console.ReadKey();
            listTwo.AddPerson(listOne.FindPersonByIndex(1));

            Console.WriteLine("\nПервый список:");
            PrintList(listOne);

            Console.WriteLine("\nВторой список:");
            PrintList(listTwo);

            Console.WriteLine("Шаг 5. Удалим второго человека " +
                "из первого спсика.");
            _ = Console.ReadKey();

            listOne.DeleteByIndex(1);

            Console.WriteLine("\nПервый список:");
            PrintList(listOne);

            Console.WriteLine("\nВторой список:");
            PrintList(listTwo);

            Console.WriteLine("Шаг 6. Очистим второй спсиок.");
            _ = Console.ReadKey();

            listTwo.ClearPerson();

            Console.WriteLine("\nВторой список:");
            PrintList(listTwo);

            // TODO: Ввод с консоли
        }

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
    }
}
