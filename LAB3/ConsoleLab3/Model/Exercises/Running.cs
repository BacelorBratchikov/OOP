using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Model.Exercises
{
    public class Running : BaseCardio, IСaloriesable
    {
        /// <summary>
        /// Минимальная скорость бега в км/ч.
        /// </summary>
        private static double MinSpeed = 0;

        /// <summary>
        /// Максимальная скорость бега человека в км/ч.
        /// </summary>
        private static double MaxSpeed = 44;

        /// <summary>
        /// Скорость.
        /// </summary>
        private double _speed;

        /// <summary>
        /// Скорость бега.
        /// </summary>
        private double Speed
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
        /// Метод проверяющий заполнение возраста.
        /// </summary>
        /// <param name="value">Скорость.</param>
        /// <returns>Скорость.</returns>
        /// <exception cref="ArgumentException">Ловится ошибка.</exception>
        private double CheckSpeed(double value)
        {
            if (value < MinSpeed || value > MaxSpeed)
            {
                throw new ArgumentException($"{value} не должен быть " +
                    $"меньше {MinSpeed} и больше {MaxSpeed}!");
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
            return Distance * (14 - 0.25 * Speed) * Speed;
        }
    }
}
