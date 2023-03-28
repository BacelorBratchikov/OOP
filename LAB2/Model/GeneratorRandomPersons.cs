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
            "Дарья",
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
        /// Рандом.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Метод создания взрослого или ребёнка.
        /// </summary>
        /// <returns>Создает рандомную персону.</returns>
        public static PersonBase GetRandomAnyPerson()
        {
            var who = _random.Next(0, 2);
            if (who > 0)
            {
                return GetRandomChild();
            }
            else
            {
                return GetRandomAdult();
            }
        }

        /// <summary>
        /// Метод создвет рандомную персону.
        /// </summary>
        /// <param name="person">Персона.</param>
        /// <param name="gender">Пол персоны.</param>
        public static void GetRandomPerson(PersonBase person,
            Gender gender = Gender.Default)
        {

            if (gender == Gender.Default)
            {
                person.Gender = (Gender)_random.Next(2);
            }
            else
            {
                person.Gender = gender;
            }

            if (person.Gender == Gender.Male)
            {
                person.Name =
                    _maleNames[new Random().Next(1, _maleNames.Length)];
                person.Surname =
                    _surnames[new Random().Next(1, _surnames.Length)];
            }
            else
            {
                person.Name =
                    _femaleNames[new Random().Next(1, _femaleNames.Length)];
                person.Surname =
                    _surnames[new Random().Next(1, _surnames.Length)] + "а";
            }
        }

        /// <summary>
        /// Рандомный взрослый.
        /// </summary>
        /// <param name="status">Семейное положение.</param>
        /// <param name="partner">Партнер взрослого.</param>
        /// <param name="gender">Пол взрослого.</param>
        /// <returns>Рандомный человек.</returns>
        public static Adult GetRandomAdult(
            MaritalStatus status = MaritalStatus.SingleWolf,
            Adult partner = null, Gender gender = Gender.Default)
        {
            Adult randomAdult = new Adult();
            GetRandomPerson(randomAdult, gender);

            // Возраст.
            randomAdult.Age =
                _random.Next(randomAdult.MinAge, randomAdult.MaxAge);

            // Семейное положение.
            MaritalStatus maritalstatus = (MaritalStatus)_random.Next(2);
            randomAdult.StatusAdualt = maritalstatus;

            if (maritalstatus == MaritalStatus.Married && partner == null)
            {
                if (randomAdult.Gender == Gender.Male)
                {
                    randomAdult.Partner = GetRandomAdult(
                        MaritalStatus.Married, randomAdult, Gender.Female);
                }
                else
                {
                    randomAdult.Partner = GetRandomAdult(
                        MaritalStatus.Married, randomAdult, Gender.Male);
                }
            }
            else
            {
                randomAdult.StatusAdualt = status;
            }

            // Работа.
            string[] job = { "НПО \"Алмаз\"",
                "Тульский оружейный завод",
                "ЛМЗ им. К. Либкнехта",
                "Кировский завод \"Маяк\"",
                "Красмаш",
                "Концерн \"Калашников\"" };

            // Безработица в РФ на 2023 год 3%.
            var getjob = _random.Next(0, 33);

            if (getjob > 0)
            {
                randomAdult.Job = job[_random.Next(0, job.Length)];
            }

            // Паспорт.
            var passport = (ulong)_random.Next
                ((int)Adult.MinPassportNumber,
                unchecked((int)Adult.MaxPassportNumber));

            randomAdult.Рassport = passport;

            return randomAdult;
        }

        /// <summary>
        /// Метод создания рандомного ребёнка.
        /// </summary>
        /// <returns>Ребенок появился. </returns>
        public static Child GetRandomChild()
        {
            Child randomChild = new Child();
            GetRandomPerson(randomChild);

            // Возраст.
            randomChild.Age = _random.Next
                (randomChild.MinAge, randomChild.MaxAge);

            // Детей без мамы по данным переписи в 2020 года 7%.
            var mother = _random.Next(0, 13);

            if (mother > 0)
            {
                randomChild.Mother = GetRandomAdult
                    (MaritalStatus.Married, randomChild.Father,
                    Gender.Female);
            }

            // Детей без отца по данным переписи в 2020 года 25-33%.
            var fathert = _random.Next(0, 3);

            if (fathert > 0)
            {
                randomChild.Father = GetRandomAdult
                    (MaritalStatus.Married, randomChild.Mother,
                    Gender.Male);
            }

            // Десткое исправительное учреждение.
            string[] kindergarten = {
                "Детский сад: \"Люблю работать\"",
                "Детский сад: \"У станка\"",
                "Детский сад: \"Ребенок по ГОСТу\"",
                "Детский сад: \"Труд\"",
                "Детский сад: \"Рожден для работы\"",
                "Детский сад: \"За ВДВ\"",
                "Детский сад: \"Авангард\"",
                "Детский сад: \"Тополь-М\""};

            string[] school = {
                "Президентский физико-математический лицей №239",
                "Общеобразовательная школа Центра педагогического мастерства",
                "Лицей научно-инженерного профиля",
                "Военно-технический кадетский корпус",
                "Нахимовское военно-морское училище",
                "Кронштадтский морской кадетский корпус",
                "Кадетский корпус радиоэлектроники",
            };

            // Ребенок будет учиться!
            var hasInstitution = _random.Next(0, 99);

            if (hasInstitution > 0)
            {
                if (randomChild.Age < 7)
                {
                    randomChild.Institution = kindergarten
                        [_random.Next(1, kindergarten.Length)];
                }
                else
                {
                    randomChild.Institution = school
                        [_random.Next(1, school.Length)];
                }
            }

            return randomChild;
        }
    }
}
