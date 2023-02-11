using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.Delegates
{
    internal class MulticastingDelegate
    {
        public delegate void rectRectangle(double height, double width);

        public void area(double height, double width)
        {
            Console.WriteLine("Area is : {0}", (width * height));
        }

        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter in : {0}", (width + height) * 2);
        }
    }
}
