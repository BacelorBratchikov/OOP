namespace Model
{
    /// <summary>
    /// Класс содержит в себе список имен и фамилий и
    /// создает рандомную персону.
    /// </summary>
    public class GeneratorRandomPersons
    {
        /// <summary>
        /// Спсиок мужских имен.
        /// </summary>
        private static string[] _maleNames =
        {
            "Артём",
            "Александр",
            "Максимр",
            "Даниил",
            "Дмитрий",
            "Иван",
            "Кирилл",
            "Никита",
            "Михаил",
            "Егор",
            "Матвей",
            "Андрей",
            "Илья",
            "Алексей"
        };

        /// <summary>
        /// Список женских имен.
        /// </summary>
        private static string[] _femaleNames =
        {
            "София",
            "Анастасия",
            "Дарья ",
            "Мария",
            "Анна",
            "Виктория",
            "Полина",
            "Елизавета",
            "Екатерина",
            "Ксения",
            "Валерия",
            "Варвара",
            "Александра",
            "Вероника"
        };

        /// <summary>
        /// Список фамилий.
        /// </summary>
        private static string[] _surnames =
        {
            "Иванов",
            "Смирнов",
            "Попов",
            "Кузнецов",
            "Васильев",
            "Петров",
            "Соколов",
            "Михайлов",
            "Новиков",
            "Федоров",
            "Морозов",
            "Волков",
            "Алексеев",
            "Лебедев"
        };

        /// <summary>
        /// Этот метод создает рандомную персону.
        /// </summary>
        /// <returns> Возвращает новую персону со всеми атрибутами. </returns>
        public static PersonBase GetRandomPerson()
        {
            Random rnd = new Random();

            Gender gender = (Gender)rnd.Next(2);
            int age = rnd.Next(PersonBase.MinAge, PersonBase.MaxAge);
            string name;
            string surname;

            if (gender == Gender.Male)
            {
                name = _maleNames[new Random().Next(1, _maleNames.Length)];
                surname = _surnames[new Random().Next(1, _surnames.Length)];
            }
            else
            {
                name = _femaleNames[new Random().Next(1, _femaleNames.Length)];
                surname = _surnames[new Random().Next(1, _surnames.Length)] + "а";
            }

            return new PersonBase(name, surname, age, gender);
        }
    }
}
