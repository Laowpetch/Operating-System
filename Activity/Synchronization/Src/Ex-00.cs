using System;
using System.Threading;
using System.Diagnostics;

namespace assignment_2
{
    class Program
    {
        private static int sum = 0;
        static void plus()
        {
            int i;
            for (i = 0; i < 1000001; i++)
            {
                sum += i;
            }
        }
        static void minus()
        {
            int i;
            for (i = 0; i < 1000001; i++)
            {
                sum -= i;
            }
        }
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Start...");
            sw.Start();
            plus();
            minus();
            sw.Stop();
            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"Time used: {sw.ElapsedMilliseconds.ToString()} ms");

        }
    }
}