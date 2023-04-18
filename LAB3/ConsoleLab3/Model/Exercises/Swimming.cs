using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercises
{
    internal class Swimming : BaseCardio, IСaloriesable
    {
        /// <summary>
        /// Gets or sets стиль плавания.
        /// </summary>
        public TypesOfSwimming SwimmingType{ get; set; }

        /// <summary>
        /// Сжигаемые калории при плаании.
        /// </summary>
        /// <returns>Потраченные калории.</returns>
        /// <exception cref="NotImplementedException">Ошибка.</exception>
        public double CalculationCalories()
        {
            switch (SwimmingType)
            {
                case TypesOfSwimming.Breaststroke:
                    return Distance * 183;

                case TypesOfSwimming.Crawl:
                    return Distance * 293;

                case TypesOfSwimming.Butterfly:
                    return Distance * 358;

                case TypesOfSwimming.OnTheBack:
                    return Distance * 163;

                default:
                    {
                        throw new ArgumentException
                        ("Зарегистрируйте новый стиль плавания" +
                        " в ассоциации спорта");
                    }
            }    
        }
    }
}
