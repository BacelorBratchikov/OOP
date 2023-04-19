namespace Model.Exercises
{
    /// <summary>
    /// Жим штанги.
    /// </summary>
    public class BarbellPress : BaseWorkout, IСaloriesable
    {
        /// <summary>
        /// Количество повторений.
        /// </summary>
        private int _repetitions;

        /// <summary>
        /// Gets or sets количество повторений.
        /// </summary>
        public int Repetitions
        {
            get
            {
                return _repetitions;
            }

            set
            {
                _repetitions = CheckRepetitions(value);
            }
        }

        /// <summary>
        /// Минимальный вес штанги в кг.
        /// </summary>
        private const double _minWeight = 6;

        /// <summary>
        /// Максимальный вес снаряда в кг.
        /// </summary>
        private const double _maxWeight = 460;

        /// <summary>
        /// Вес.
        /// </summary>
        private double _weight;

        /// <summary>
        /// Gets or sets поднимаемый вес.
        /// </summary>
        public double Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                _weight = CheckWeight(value);
            }
        }

        /// <summary>
        /// Метод проверяющий заполнение повторений.
        /// </summary>
        /// <param name="value">Повторения.</param>
        /// <returns>Повторения.</returns>
        /// <exception cref="ArgumentException">Ловится ошибка.</exception>
        private int CheckRepetitions(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{value} не может быть " +
                    $"отрицательным!");
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Метод проверяющий заполнение веса.
        /// </summary>
        /// <param name="value">Вес.</param>
        /// <returns>Вес.</returns>
        /// <exception cref="ArgumentException">Ловится ошибка.</exception>
        private double CheckWeight(double value)
        {
            if (value < _minWeight || value > _maxWeight)
            {
                throw new ArgumentException($"{value} не должен быть " +
                    $"меньше {_minWeight} и больше {_maxWeight}!");
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Вычисление расхода калориев при беге.
        /// </summary>
        /// <returns>Потраченные калории.</returns>
        public double CalculationCalories()
        {
            return Weight * Repetitions / 3;
        }
    }
}
