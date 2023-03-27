namespace Model
{
    /// <summary>
    /// Взрослый наследник от PersonBase.
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Gets минимальный возраст.
        /// </summary>
        public override int MinAge => 18;

        /// <summary>
        /// Gets максимальный возраст.
        /// </summary>
        public override int MaxAge => 1000;

        /// <summary>
        /// Минимальный номер паспорта.
        /// </summary>
        public const ulong MinPassportNumber = 1000000001;

        /// <summary>
        /// Максимальный номер паспорта.
        /// </summary>
        public const ulong MaxPassportNumber = 9999999999;

        /// <summary>
        /// Паспорт.
        /// </summary>
        private ulong _passport;

        /// <summary>
        /// Партнер.
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// Gets or sets задание семейного положения.
        /// </summary>
        public MaritalStatus StatusAdualt { get; set; }

        /// <summary>
        /// Gets or sets задание работы.
        /// </summary>
        public string? Job { get; set; }

        /// <summary>
        /// Gets or sets задание паспорта.
        /// </summary>
        public ulong Рassport
        {
            get
            {
                return _passport;
            }

            set
            {
                _passport = CheckPassport(value);
            }
        }

        /// <summary>
        /// Gets or sets задание партнера.
        /// </summary>
        public Adult Partner
        {
            get
            {
                return _partner;
            }

            set
            {
                _partner = CheckPartner(value);
            }
        }

        /// <summary>
        /// Проверка на отношения супругов.
        /// </summary>
        /// <param name="value">Партнер.</param>
        /// <returns>Партнер.</returns>
        /// <exception cref="ArgumentException">Ловится ошибка.</exception>
        public Adult CheckPartner(Adult value)
        {
            if (StatusAdualt == value.StatusAdualt &&
                value.StatusAdualt == MaritalStatus.Married)
            {
                return value;
            }
            else
            {
                throw new ArgumentException("Есть проблемы в отношениях?" +
                    "Обратитесь к семейному психологу " +
                    "по номеру: 88005553535. Звонок бесплатный. Ждем вас!");
            }
        }

        /// <summary>
        /// Проверка паспорта.
        /// </summary>
        /// <param name="value">Значение паспорта.</param>
        /// <returns>Номер паспорта.</returns>
        /// <exception cref="ArgumentException">Исключение.</exception>
        public ulong CheckPassport(ulong value)
        {
            if (value >= MinPassportNumber || value <= MaxPassportNumber)
            {
                return value;
            }
            else
            {
                throw new ArgumentException($"Введён некорректный" +
                    $" номер паспорта, введите " +
                    $" от {MinPassportNumber} до {MaxPassportNumber}!");
            }
        }

        /// <summary>
        /// Метод получения информации.
        /// </summary>
        /// <returns>Информация о работе.</returns>
        public override string GetInfo()
        {
            string personInfo = base.GetInfo();

            personInfo += $"\nДанные о паспорте: {Рassport}, " +
                          $"\nСемейное положение: {StatusAdualt}, ";
            if (StatusAdualt == MaritalStatus.Married)
            {
                personInfo += $"\tВторая половинка: {Partner.Name} " +
                              $"{Partner.Surname}, ";
            }
            else
            {
                personInfo += "\tНе расстраивайся, все впереди";
            }

            personInfo += "\nРабота: ";
            if (string.IsNullOrEmpty(Job))
            {
                personInfo += "Тунеядец не нужен государству! " +
                    "Твой билет отныне - строить БАМ 2!";
            }
            else
            {
                personInfo += Job;
            }

            return personInfo;
        }
    }
}
