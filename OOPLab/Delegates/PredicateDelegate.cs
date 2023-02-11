using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.Delegates
{
    internal class PredicateDelegate
    {
        public delegate bool my_delegate(string mystring);

        public static bool myfun(string mystring)
        {
            if (mystring.Length < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
