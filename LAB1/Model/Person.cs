namespace Model
{
    /// <summary>
    /// Класс содержит информацию о персонах.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст.
        /// </summary>
        private int _age;

        /// <summary>
        /// Пол.
        /// </summary>
        private Gender _gender;

        /// <summary>
        /// Минимальный возраст.
        /// </summary>
        public const int MinAge = 0;

        /// <summary>
        /// Максимальный возраст.
        /// </summary>
        public const int MaxAge = 150;

        /// <summary>
        /// Gets имя.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            private set
            {
                _name = CheckString(value, nameof(Name));
            }
        }

        /// <summary>
        /// Gets фамилия.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }

            private set
            {
                _surname = CheckString(value, nameof(Surname));
            }
        }

        /// <summary>
        /// Gets возраст.
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }

            private set
            {
                _age = CheckAge(value);
            }
        }

        /// <summary>
        /// Gets пол.
        /// </summary>
        public Gender Gender
        {
            get
            {
                return _gender;
            }

            private set
            {
                _gender = value;
            }
        }

        /// <summary>
        /// Метод проверяющий заполнение имени и фамилии.
        /// </summary>
        /// <param name="value">Имя или Фамилия.</param>
        /// <param name="propertyName">приоритетность имени.</param>
        /// <returns>Возвращается имя и фамилия.</returns>
        /// <exception cref="ArgumentException">Ловится ошибка.</exception>
        private string CheckString(string value, string propertyName)
        {

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{propertyName} не должен" +
                    $" быть пустым!");
            }

            return value;
        }

        /// <summary>
        /// Метод проверяющий заполнение возраста.
        /// </summary>
        /// <param name="value">Возраст.</param>
        /// <returns>Возраст.</returns>
        /// <exception cref="ArgumentException">Ловится ошибка.</exception>
        private int CheckAge(int value)
        {
            if (value < MinAge || value > MaxAge)
            {
                throw new ArgumentException($"{value} не должен быть " +
                    $"меньше {MinAge} и больше {MaxAge}!");
            }

            return value;
        }

        /// <summary>
        /// Метод проверяющий заполнение пола.
        /// </summary>
        /// <param name="value">Пол.</param>
        /// <returns>Пол.</returns>
        /// <exception cref="Exception">Ловится ошибка.</exception>
        private int CheckGender(int value)
        {
            if (value != (1 | 0))
            {
                throw new Exception("Тебе стоит пересмотреть свои убеждения" +
                    " существует только мужской пол - 0 и женский - 1!");
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Создается экземпляр класса <see cref="Person"/>.
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <exception cref="ArgumentException">
        /// Имя не должно быть пустым или null.
        /// </exception>
        public Person(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;

            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Создается пустой экземпляр класса <see cref="Person"/>.
        /// </summary>
        public Person()
        { }

        /// <summary>
        /// Функция возвращает информацию о персонах
        /// </summary>
        /// <returns>Возвращает информацию о персонах</returns>
        public string GetInfo()
        {
            return $"Имя персоны: {_name}, фамилия: {_surname}," +
                $" возраст: {_age}, пол: {_gender}. \n";
        }
    }
}
