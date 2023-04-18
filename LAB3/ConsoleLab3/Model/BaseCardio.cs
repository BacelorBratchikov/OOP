using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Model
{
    public abstract class BaseCardio
    {
        /// <summary>
        /// Расстояние.
        /// </summary>
        private double _distance;

        /// <summary>
        /// Расстояние преодаленное.
        /// </summary>
        protected double Distance
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
            else
            {
                return value;
            }
        }
    }
}
