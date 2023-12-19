using Model.BaseAbstractClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    //TODO(+): XML
    /// <summary>
    /// Класс списка событий при добавлении упражнений.
    /// </summary>
    public class ExerciseListEventArgs : EventArgs
    {
        /// <summary>
        /// Gets спсиок упражнений.
        /// </summary>
        public BindingList<BaseExerсise> ExerсiseList { get; private set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExerciseListEventArgs"/> class.
        /// Конструктор события добавления упражнений.
        /// </summary>
        /// <param name="exerсice">Упражнение.</param>
        public ExerciseListEventArgs(BindingList<BaseExerсise> exerсice)
        {
            this.ExerсiseList = exerсice;
        }
    }
}
