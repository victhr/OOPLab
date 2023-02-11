using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.OOP
{
    public abstract class AbstractClass
    {
        public int AddTwoNumbes(int x, int y)
        {
            return x + y;
        }

        public abstract int MultiplyTwoNumbers(int x, int y);

        public virtual int MakeAnyOperation(int x, int y)
        {
            return x - y;
        }
    }

    public class derivedClass : AbstractClass
    {
        public override int MultiplyTwoNumbers(int x, int y)
        {
            return x * y;
        }

        public override sealed int MakeAnyOperation(int x, int y)
        {
            return (x * y) - y;
            //return base.MakeAnyOperation(x, y);
        }
    }

    public class SealedClass : derivedClass
    {
        public override int MultiplyTwoNumbers(int x, int y)
        {
            return base.MultiplyTwoNumbers(x, y);   
        }

       /* public override int MakeAnyOperation(int x, int y)
        {
            return (x * y) - y;
            //return base.MakeAnyOperation(x, y);
        }*/
    }
}
