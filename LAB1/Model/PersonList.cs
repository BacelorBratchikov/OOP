using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // TODO: add person in person именно сюда добавить, так как ввод новой персоны из консоли.
    public class PersonList
    {
        private Person[] ListPerson = new Person[0];

        /*
        private Person this[int index]
        {
            get { }
            set { }
        }
        */

        public int DleteByIndex(int index)
        {
            return index;
        }

    }
}
