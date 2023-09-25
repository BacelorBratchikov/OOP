using System.ComponentModel;

namespace Model.Exercises
{
    /// <summary>
    /// Жим штанги.
    /// </summary>
    public class BarbellPress : IInformationaly
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
            return value < 0
                ? throw new ArgumentException($"{value} должно быть " +
                    $"целым и положитеьным!")
                : value;
        }

        /// <summary>
        /// Gets метод, возвращающий информацию об упражнениях.
        /// </summary>
        public string TypeOfExerise => "Жим штанги";

        /// <summary>
        /// Метод проверяющий заполнение веса.
        /// </summary>
        /// <param name="value">Вес.</param>
        /// <returns>Вес.</returns>
        /// <exception cref="ArgumentException">Ловится ошибка.</exception>
        private double CheckWeight(double value)
        {
            return value < _minWeight || value > _maxWeight
                ? throw new ArgumentException($"{value} не должен быть " +
                    $"меньше {_minWeight} и больше {_maxWeight}!")
                : value;
        }

        /// <summary>
        /// Вычисление расхода калориев при жиме штанги.
        /// </summary>
        /// <returns>Потраченные калории.</returns>
        public double CalculationCalories()
        {
            return Weight * Repetitions / 3;
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="repetitions">Повторения.</param>
        /// <param name="weight">Вес.</param>
        public BarbellPress(int repetitions, double weight)
        {
            Repetitions = repetitions;
            Weight = weight;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public BarbellPress()
        { }

        /// <summary>
        /// Gets информация по жиму штанги.
        /// </summary>
        public string GetInfo =>
            $"Подходов: {Repetitions}, вес: {Weight}.";
    }
}
