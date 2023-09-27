using Model.Exercises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model.BaseAbstractClass
{
    /// <summary>
    /// Базовый класс информации об упражнениях.
    /// </summary>
    [XmlInclude(typeof(BarbellPress))]
    [XmlInclude(typeof(Running))]
    [XmlInclude(typeof(Swimming))]
    public abstract class BaseExerсise
    {
        /// <summary>
        /// Gets метод, возвращающий тип упражнения.
        /// </summary>
        [DisplayName("Тип упражнения")]
        public abstract string TypeOfExerise { get; }

        /// <summary>
        /// Gets метод, возвращающий информацию об упражнениях.
        /// </summary>
        [DisplayName("Информация об упражнениях")]
        public abstract string GetInfo { get; }

        /// <summary>
        /// Gets метод, возвращающий информацию о сожженых калориях.
        /// </summary>
        [DisplayName("Калориев сожжено, ккал")]
        public abstract double Calories { get; }

        /// <summary>
        /// Конструктор по умолчания.
        /// </summary>
        protected BaseExerсise()
        { }
    }
}
