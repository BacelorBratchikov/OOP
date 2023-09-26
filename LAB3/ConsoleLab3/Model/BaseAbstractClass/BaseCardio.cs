namespace Model.BaseAbstractClass
{
    /// <summary>
    /// Базовый класс для кардио упражнений.
    /// </summary>
    public abstract class BaseCardio : BaseExerсice
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
            return value < _minDistance || value > _maxDistance
                ? throw new ArgumentException($"{value} не должен быть " +
                    $"меньше {_minDistance} и больше {_maxDistance}!")
                : value;
        }
    }
}
