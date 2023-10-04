using Model.BaseAbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    /// <summary>
    /// Класс событий.
    /// </summary>
    public class ExerciseEventArgs : EventArgs
    {
        /// <summary>
        /// Gets упражнение.
        /// </summary>
        public BaseExerсise Exerсise { get; private set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExerciseEventArgs"/> class.
        /// Конструктор события добавления упражнения.
        /// </summary>
        /// <param name="exerсise">упражнение.</param>
        public ExerciseEventArgs(BaseExerсise exerсise)
        {
            Exerсise = exerсise;
        }
    }
}
