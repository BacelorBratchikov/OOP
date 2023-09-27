using Model.BaseAbstractClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    internal class ExerciseListEventArgs : EventArgs
    {
        /// <summary>
        /// Gets фигура.
        /// </summary>
        public BindingList<BaseExerсise> ExerсiceList { get; private set; }

        /// <summary>
        /// Конструктор события добавления фигуры.
        /// </summary>
        /// <param name="exerсice">Упражнение.</param>
        public ExerciseListEventArgs(BindingList<BaseExerсise> exerсice)
        {
            this.ExerсiceList = exerсice;
        }
    }
}
