namespace Model.Exercises
{
    /// <summary>
    /// Плавание.
    /// </summary>
    public class Swimming : BaseCardio, IСaloriesable
    {
        /// <summary>
        /// Gets or sets стиль плавания.
        /// </summary>
        public TypesOfSwimming SwimmingType { get; set; }

        /// <summary>
        /// Словарь, в котором ключ - тип плавания, а значение - его
        /// калорийные затраты.
        /// </summary>
        private static Dictionary<TypesOfSwimming, int>
            _dictCalorieBySwimmingType = new Dictionary<TypesOfSwimming, int>()
            {
                [TypesOfSwimming.Breaststroke] = 183,
                [TypesOfSwimming.Crawl] = 293,
                [TypesOfSwimming.Butterfly] = 358,
                [TypesOfSwimming.OnTheBack] = 163
            };

        /// <summary>
        /// Сжигаемые калории при плавании.
        /// </summary>
        /// <returns>Потраченные калории.</returns>
        /// <exception cref="NotImplementedException">Ошибка.</exception>
        public double CalculationCalories()
        {
            switch (SwimmingType)
            {
                case TypesOfSwimming.Breaststroke:
                    return Distance * _dictCalorieBySwimmingType
                        [TypesOfSwimming.Breaststroke];

                case TypesOfSwimming.Crawl:
                    return Distance * _dictCalorieBySwimmingType
                        [TypesOfSwimming.Crawl];

                case TypesOfSwimming.Butterfly:
                    return Distance * _dictCalorieBySwimmingType
                        [TypesOfSwimming.Butterfly];

                case TypesOfSwimming.OnTheBack:
                    return Distance * _dictCalorieBySwimmingType
                        [TypesOfSwimming.OnTheBack];

                default:
                    {
                        throw new ArgumentException
                        ("Зарегистрируйте новый стиль плавания" +
                        " в ассоциации спорта");
                    }
            }
        }
    }
}
