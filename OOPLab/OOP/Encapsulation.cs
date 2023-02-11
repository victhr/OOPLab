using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.OOP
{
    internal class Encapsulation
    {
        private int _Z;

        public int Z
        {
            get
            {
                return _Z;
            }
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
