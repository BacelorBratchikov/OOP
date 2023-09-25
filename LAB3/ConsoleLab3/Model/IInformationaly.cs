using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Интерфейс с методом информации об упражнениях.
    /// </summary>
    internal interface IInformationaly : IСaloriesable
    {
        /// <summary>
        /// Gets метод, возвращающий информацию об упражнениях.
        /// </summary>
        [DisplayName("Информация об упражнениях")]
        public abstract string GetInfo { get; }

        /// <summary>
        /// Gets метод, возвращающий информацию об упражнениях.
        /// </summary>
        [DisplayName("Информация об упражнениях")]
        public abstract string TypeOfExerise { get; }
    }
}
