using Model.BaseAbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.AddExercises.Interface
{
    /// <summary>
    /// Интерфейс добавления упражнения.
    /// </summary>
    internal interface IAddedable
    {
        /// <summary>
        /// Метод добавления упражнения.
        /// </summary>
        /// <returns>Упражнение.</returns>
        internal abstract BaseExerсise AddExercise();
    }
}