using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.Asynchronous
{
    internal class Asynchronous
    {
        public static void SynDemo()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            var task1 = StartSchoolAssembly();
            var task2 = TeachClass1();
            var task3 = TeachClass2();

            Task.WaitAll(task1, task2, task3);

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        public static async Task StartSchoolAssembly()
        {
            await Task.Run(() => {
                Thread.Sleep(8000);
                Console.WriteLine("School Started");
            });
        }

        public static async Task TeachClass1()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Executing teach 1");
            });
        }

        public static async Task TeachClass2()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Executing Teach 2");
            });
        }
    }
}
