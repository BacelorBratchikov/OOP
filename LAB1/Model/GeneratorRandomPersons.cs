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
        private string[] _maleName =
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
        private string[] _femaleName =
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
        private string[] _surname =
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
        public Person GetRandomPerson()
        {
            Random rnd = new Random();

            Gender gender = (Gender)rnd.Next(2);
            int age = rnd.Next(Person.MinAge, Person.MaxAge);
            string name;
            string surname;

            if (gender == Gender.Male)
            {
                name = _maleName[new Random().Next(1, _maleName.Length)];
                surname = _surname[new Random().Next(1, _surname.Length)];
            }

            else
            {
                name = _femaleName[new Random().Next(1, _femaleName.Length)];
                surname = _surname[new Random().Next(1, _surname.Length)] + "а";
            }

            return new Person(name, surname, age, gender);
        }
    }
}
