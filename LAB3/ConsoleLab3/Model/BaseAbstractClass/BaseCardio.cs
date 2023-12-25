namespace Model.BaseAbstractClass
{
    /// <summary>
    /// Базовый класс для кардио упражнений.
    /// </summary>
    public abstract class BaseCardio : BaseExerсise
    {
        /// <summary>
        /// Минимальное расстояние.
        /// </summary>
        internal const double _minDistance = 0;

        /// <summary>
        /// Максимальное расстояние марафона.
        /// </summary>
        internal const double _maxDistance = 560;

        /// <summary>
        /// Расстояние.
        /// </summary>
        private double _distance;

        /// <summary>
        /// Gets or sets расстояние преодаленное.
        /// </summary>
        public double Distance
        {
            get
            {
                return _distance;
            }

            set
            {
                _distance = CheckDistance(value);
            }
        }

        /// <summary>
        /// Метод проверяющий заполнение расстояния.
        /// </summary>
        /// <param name="value">Расстояние.</param>
        /// <returns>Расстояние.</returns>
        /// <exception cref="ArgumentException">Ловится ошибка.</exception>
        private double CheckDistance(double value)
        {
            if (value < _minDistance || value > _maxDistance || value is double.NaN)
            {
                throw new ArgumentException($"" +
                $"Введеное расстояние составляет:{value} км. " +
                $"Преодаленное расстояние не может быть меньше " +
                $"{_minDistance} км и больше {_maxDistance} км!");
            }
            else
            {
                return (double)value;
            }
        }
    }
}
