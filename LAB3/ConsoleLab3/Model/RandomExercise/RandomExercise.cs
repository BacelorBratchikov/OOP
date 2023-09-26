using Model.BaseAbstractClass;
using Model.EnumsDifferentTypes;
using Model.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model.RandomExercise
{
    /// <summary>
    /// Метод создания рандомного упражнения.
    /// </summary>
    public class RandomExercise : BaseRandomExerise
    {

        /// <summary>
        /// Метод для получения случайного экземпляра упражнений.
        /// </summary>
        /// <param name="typeOfExerise">Тип упражнения.</param>
        /// <returns>Экземпляр случайного упражнения.</returns>
        /// <exception cref="ArgumentException">Ошибка о несуществовании
        /// типа упражнения.</exception>
        public override BaseExerсice GetInstance(TypesOfExerise typeOfExerise)
        {
            double tmpDistance = GetRandomValue
                (BaseCardio._minDistance, BaseCardio._maxDistance);
            double tmpWight = GetRandomValue
                (BarbellPress._minWeight, BarbellPress._maxWeight);
            double tmpSpeed = GetRandomValue
                (Running._minSpeed, Running._maxSpeed);
            int tmpRepetitions = GetRandomWholeValue
                (BarbellPress._minRepetitions, BarbellPress._maxRepetitions);
            TypesOfSwimming tmpSwimmingType = GetRandomTypeOfSwimming();

            switch (typeOfExerise)
            {
                case TypesOfExerise.BarbellPres:
                    {
                        return new BarbellPress(tmpRepetitions, tmpWight);
                    }

                case TypesOfExerise.Running:
                    {
                        return new Running(tmpDistance, tmpSpeed);
                    }

                case TypesOfExerise.Swimming:
                    {
                        return new Swimming(tmpDistance, tmpSwimmingType);
                    }

                default:
                    throw new ArgumentException
                        ("Неизвестный тип упражнения.");

            }
        }
    }
}
