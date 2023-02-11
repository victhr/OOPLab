using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.Delegates
{
    internal class SimpleDelegate
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum a + b = {0}", a + b);
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine("Sub a -b = {0}", a - b);
        }
    }
}
