using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercises
{
    public class BarbellPress : IСaloriesable
    {
        /// <summary>
        /// Количество повторений.
        /// </summary>
        private int _repetitions;

        /// <summary>
        /// Количество повторений.
        /// </summary>
        protected int Repetitions
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
        private static double MinWeight = 6;

        /// <summary>
        /// Максимальный вес снаряда в кг.
        /// </summary>
        private static double MaxWeight = 460;

        /// <summary>
        /// Скорость.
        /// </summary>
        private double _weight;

        /// <summary>
        /// Скорость бега.
        /// </summary>
        private double Weight
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
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException($"{value} не должен быть " +
                    $"меньше {MinWeight} и больше {MaxWeight}!");
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
            return Weight * Repetitions/3; 
        }
    }
}
