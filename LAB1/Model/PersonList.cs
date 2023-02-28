using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // TODO: add person in person именно сюда добавить, так как ввод новой персоны из консоли.

    /// <summary>
    /// Класс Список персон.
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Список людей.
        /// </summary>
        private Person[] _personList = new Person[0];

        /// <summary>
        /// Удаление по индексу.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Индекс.</returns>
        public int DleteByIndex(int index)
        {
            return index;
        }

    }
}
