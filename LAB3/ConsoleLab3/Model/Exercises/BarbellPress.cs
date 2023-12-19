using System.ComponentModel;
using Model.BaseAbstractClass;
using Model.Interface;

namespace Model.Exercises
{
    /// <summary>
    /// Жим штанги.
    /// </summary>
    public class BarbellPress : BaseExerсise, IСaloriesable
    {
        /// <summary>
        /// Минимальный вес штанги в кг.
        /// </summary>
        internal const int _minRepetitions = 0;

        /// <summary>
        /// Максимальное число повторений на 2023.
        /// </summary>
        internal const int _maxRepetitions = 1830;

        /// <summary>
        /// Повторения.
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
        internal const double _minWeight = 6;

        /// <summary>
        /// Максимальный вес снаряда в кг.
        /// </summary>
        internal const double _maxWeight = 460;

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
        /// <summary>
        /// Gets метод, возвращающий информацию о типе упражнения.
        /// </summary>
        public override string TypeOfExerise => "Жим штанги";

        /// <summary>
        /// Gets информация по жиму штанги.
        /// </summary>
        public override string GetInfo =>
            $"Подходов: {Repetitions} раз; вес: {Weight} кг.";

        /// <summary>
        /// Gets информация по сожженым калориям.
        /// </summary>
        public override double Calories =>
            CalculationCalories();

        /// <summary>
        /// Метод проверяющий заполнение повторений.
        /// </summary>
        /// <param name="value">Повторения.</param>
        /// <returns>Повторения.</returns>
        /// <exception cref="ArgumentException">Ловится ошибка.</exception>
        private int CheckRepetitions(int value)
        {
            return value < _minRepetitions || value > _maxRepetitions
               ? throw new ArgumentException(
                   $"Введеное количество повтарений составляет:{value} раз. " +
                   $"Повторений не должен быть меньше {_minRepetitions} " +
                   $"раз и больше {_maxRepetitions} раз!")
               : value;
        }

        /// Метод проверяющий заполнение веса.
        /// </summary>
        /// <param name="value">Вес.</param>
        /// <returns>Вес.</returns>
        /// <exception cref="ArgumentException">Ловится ошибка.</exception>
        private double CheckWeight(double value)
        {
            return value < _minWeight || value > _maxWeight
                ? throw new ArgumentException(
                    $"Введеный вессоставляет:{value} кг. Вес не должен быть " +
                    $"меньше {_minWeight} кг и больше {_maxWeight} кг!")
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
        /// Конструктор по умолчанию.
        /// </summary>
        public BarbellPress()
        { }

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
    }
}
