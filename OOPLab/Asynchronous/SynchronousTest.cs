using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.Asynchronous
{
    internal class SynchronousTest
    {
        public static void SynDemo()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            StartSchoolassembly();
            TeachClass1();
            TeachClass2();
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        public static void StartSchoolassembly()
        {
            Thread.Sleep(8000);
            Console.WriteLine("School Thread");
        }

        public static void TeachClass1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Executng Teach class 1");
        }

        public static void TeachClass2()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Exectng Teach Class 2");
        }
    }
}
