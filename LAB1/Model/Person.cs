using System;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Класс содержит информацию о персонах
    /// </summary>
    public class Person
    {

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
        
        /// <summary>
        /// Метод проверяющий заполнение имени и фамилии
        /// </summary>
        /// <param name="value">Имя или Фамилия</param>
        /// <param name="propertyName">приоритетность имени</param>
        /// <returns>Возвращается имя и фамилия</returns>
        /// <exception cref="ArgumentException"></exception>
        private string CheckString(string value, string propertyName)
        {
            if (value == null)
            {
                throw new ArgumentException($"{propertyName} should not be null!");
            }

            if (value == string.Empty)
            {
                throw new ArgumentException($"{propertyName} should not be empty!");
            }
            return value;
        }


        internal string _name;

        private string _surname;

        private int _age;

        private Gender _gender;

        public Person Partner;

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

            _age = age;
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
                $" age is {_age}, gender is {_gender}. \n" +
                $"Person Partner {Partner?.GetInfo()}";
        }

        /// <summary>
        /// Функция позволяет добавлять год при праздновании ДР
        /// </summary>
        public void CelebrateHappyBerthday()
        {
            _age++;
        }
        
    }
}