using System;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Класс содержит информацию о персонах
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
        /// Метод проверяющий заполнение имени и фамилии
        /// </summary>
        /// <param name="value">Имя или Фамилия</param>
        /// <param name="propertyName">приоритетность имени</param>
        /// <returns>Возвращается имя и фамилия</returns>
        /// <exception cref="ArgumentException"></exception>
        private string CheckString(string value, string propertyName)
        {

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{propertyName} не должен" +
                    $" быть пустым!");
            }

            return value;
        }

        private int CheckAge(int value)
        {
            if (value < 0 | value > 150)
            {
                throw new ArgumentException($"{value} не мдолжен быть " +
                    $"отрицательным и больше 150!");
            }

            return value;
        }

        /// <summary>
        /// Создается эеземпляр класса <see cref="Person"/>.
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <exception cref="ArgumentException">
        /// Имя не должно быть пустым или null
        /// </exception>
        public Person(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;

            Age = age;
            _gender = gender;
        }

        public Person(string name, string surname, int age):
            this (name, surname, age, default(Gender)) { }

        /// <summary>
        /// Функция возвращает информацию о персонах
        /// </summary>
        /// <returns>Возвращает информацию о персонах</returns>
        public string GetInfo()
        {
            return $"Person name: {_name}, surname {_surname}," +
                $" age is {_age}, gender is {_gender}. \n";
        }
    }
}
