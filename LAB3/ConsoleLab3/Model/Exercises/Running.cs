namespace Model.Exercises
{
    /// <summary>
    /// Бег.
    /// </summary>
    public class Running : BaseCardio, IСaloriesable
    {
        /// <summary>
        /// Минимальная скорость бега в км/ч.
        /// </summary>
        private const double _minSpeed = 0;

        /// <summary>
        /// Максимальная скорость бега человека в км/ч.
        /// </summary>
        private const double _maxSpeed = 44;

        /// <summary>
        /// Скорость.
        /// </summary>
        private double _speed;

        /// <summary>
        /// Переменный коэффициент учитывающий снижение расхода
        /// сжигания калориев при увеличении скорости.
        /// </summary>
        private const double _variableCoefficientSpeed = 0.25;

        /// <summary>
        /// Постоянный коэффициент учитывающий сжигание калориев
        /// при минимальной скорости бега.
        /// </summary>
        private const double _constantCoefficientSpeed = 14;

        /// <summary>
        /// Gets or sets скорость бега.
        /// </summary>
        public double Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = CheckSpeed(value);
            }
        }

        /// <summary>
        /// Gets метод, возвращающий информацию о типе упражнения.
        /// </summary>
        public override string TypeOfExerise => "Бег";

        /// <summary>
        /// Gets информация по скорости бега.
        /// </summary>
        public override string GetInfo =>
            $"Дистанция: {Distance}, скорость: {Speed}.";

        /// <summary>
        /// Gets информация по сожженым калориям.
        /// </summary>
        public override double Calories =>
            CalculationCalories();

        /// <summary>
        /// Метод проверяющий заполнение возраста.
        /// </summary>
        /// <param name="value">Скорость.</param>
        /// <returns>Скорость.</returns>
        /// <exception cref="ArgumentException">Ловится ошибка.</exception>
        private double CheckSpeed(double value)
        {
            if (value < _minSpeed || value > _maxSpeed)
            {
                throw new ArgumentException($"{value} не должен быть " +
                    $"меньше {_minSpeed} и больше {_maxSpeed}!");
            }

            return value;
        }

        /// <summary>
        /// Вычисление расхода калориев при беге.
        /// </summary>
        /// <returns>Потраченные калории.</returns>
        public double CalculationCalories()
        {
            return Distance * (_constantCoefficientSpeed -
                _variableCoefficientSpeed * Speed) * Speed;
        }
    }
}
