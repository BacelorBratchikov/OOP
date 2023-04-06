using System.Globalization;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Класс содержит информацию о персонах.
    /// </summary>
    public abstract class PersonBase
    {
        /// <summary>
        /// Gets минимальный возраст.
        /// </summary>
        public abstract int MinAge { get; }

        /// <summary>
        /// Gets максимальный возраст.
        /// </summary>
        public abstract int MaxAge { get; }

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
        /// Gets or sets имя.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                CheckString(value, nameof(_name));
                _ = CheckLanguage(EditRegister(value));

                if (_surname != null)
                {
                    CheckNameAndSurname();
                }
            }
        }

        /// <summary>
        /// Gets or sets фамилия.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                CheckString(value, nameof(_surname));
                _ = CheckLanguage(EditRegister(value));

                if (_name != null)
                {
                    CheckNameAndSurname();
                }
            }
        }

        /// <summary>
        /// Gets or sets возраст.
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = CheckAge(value);
            }
        }

        /// <summary>
        /// Gets or sets пол.
        /// </summary>
        public Gender Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        /// <summary>
        /// Создается экземпляр класса <see cref="PersonBase"/>.
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <exception cref="ArgumentException">
        /// Имя не должно быть пустым или null.
        /// </exception>
        public PersonBase(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;

            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Создается пустой экземпляр класса <see cref="PersonBase"/>.
        /// </summary>
        public PersonBase()
        { }

        /// <summary>
        /// Метод проверяющий заполнение имени и фамилии.
        /// </summary>
        /// <param name="value">Имя или Фамилия.</param>
        /// <param name="propertyName">приоритетность имени.</param>
        /// <exception cref="ArgumentException">Ловится ошибка.</exception>
        private void CheckString(string value, string propertyName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{propertyName} не должен" +
                    $" быть пустым!");
            }
        }

        /// <summary>
        /// Метод распознает язык в строке.
        /// </summary>
        /// <param name="name">Строка.</param>
        private static Language CheckLanguage(string name)
        {
            var engLanguage = new Regex(@"^[A-z]+(-[A-z])?[A-z]*$");
            var rusLanguage = new Regex(@"^[А-я]+(-[А-я])?[А-я]*$");

            if (string.IsNullOrEmpty(name) == false)
            {
                if (engLanguage.IsMatch(name))
                {
                    return Language.English;
                }
                else if (rusLanguage.IsMatch(name))
                {
                    return Language.Russian;
                }
                else
                {
                    throw new ArgumentException("Я тебя не понимать! Ты " +
                        "что-то не так вводишь. Только русский или английский!");
                }
            }

            return Language.Basurman;
        }

        /// <summary>
        /// Проверяет имя и фамилию на язык.
        /// </summary>
        /// <exception cref="FormatException">Один язык.</exception>
        private void CheckNameAndSurname()
        {
            var nameLanguage = CheckLanguage(Name);
            var surnameLanguage = CheckLanguage(Surname);

            if (nameLanguage != surnameLanguage)
            {
                throw new FormatException("Имя и фамилия должны быть " +
                    "написаны на одном языке.");
            }
        }

        /// <summary>
        /// Приводит строку к соответствующему регистру.
        /// </summary>
        /// <param name="name">Имя или фамилия.</param>
        /// <returns>Имя или фамилия с учетом регистров.</returns>
        private static string EditRegister(string name)
        {
            return CultureInfo.CurrentCulture.TextInfo.
                ToTitleCase(name.ToLower());
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
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Функция возвращает информацию о персонах.
        /// </summary>
        /// <returns>Возвращает информацию о персонах.</returns>
        public virtual string GetInfo()
        {
            return $"{Name} {Surname}, \t" +
                $"возраст: {Age}, пол: {Gender}. \n";
        }
    }
}
