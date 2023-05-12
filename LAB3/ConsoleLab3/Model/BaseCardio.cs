namespace Model
{
    /// <summary>
    /// Базовый класс для кардио упражнений.
    /// </summary>
    public class BaseCardio
    {
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
            if (value < 0)
            {
                throw new ArgumentException($"{value} не может быть " +
                    $"отрицательным! Кардио нагрузки не имеют вектора.");
            }

            return value;
        }
    }
}
