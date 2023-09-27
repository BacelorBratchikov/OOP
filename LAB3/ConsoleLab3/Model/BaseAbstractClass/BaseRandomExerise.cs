using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EnumsDifferentTypes;

namespace Model.BaseAbstractClass
{
    /// <summary>
    /// Базовый класс создания рандомных упражнений.
    /// </summary>
    public abstract class BaseRandomExerise
    {
        /// <summary>
        /// Получить экземпляр типа упражнения.
        /// </summary>
        /// <param name="typeOfExerise">Тип упражнения.</param>
        /// <returns>Экземпляр класса BaseExerсice.</returns>
        public abstract BaseExerсise GetInstance
            (TypesOfExerise typeOfExerise);

        /// <summary>
        /// Генератор рандомного типа плавания.
        /// </summary>
        /// <returns>Случайный тип плавания.</returns>
        public TypesOfSwimming GetRandomTypeOfSwimming()
        {
            var random = new Random();
            TypesOfSwimming randomTypeOfSwimming = (TypesOfSwimming)
                random.Next(4);
            return randomTypeOfSwimming;
        }

        /// <summary>
        /// Метод возвращает случайное число в указанном диапазоне.
        /// </summary>
        /// <param name="minValue">Минимальное число.</param>
        /// <param name="maxValue">Максимальное число.</param>
        /// <returns>Случайное число.</returns>
        public double GetRandomValue(double minValue, double maxValue)
        {
            var rnd = new Random();
            double tmpValue = rnd.Next((int)minValue, (int)maxValue);
            return tmpValue;
        }

        /// <summary>
        /// Метод возвращает случайное целое число в указанном диапазоне.
        /// </summary>
        /// <param name="minValue">Минимальное число.</param>
        /// <param name="maxValue">Максимальное число.</param>
        /// <returns>Случайное число.</returns>
        public int GetRandomWholeValue(int minValue, int maxValue)
        {
            var rnd = new Random();
            int tmpValue = rnd.Next(minValue, maxValue);
            return tmpValue;
        }
    }
}
