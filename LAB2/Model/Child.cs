using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Child : PersonBase
    {
        /// <summary>
        /// Минимальный возраст
        /// </summary>
        public override int MinAge => 0;

        /// <summary>
        /// Максимальный возраст
        /// </summary>
        public override int MaxAge => 17;

    }
}
