using System;
using System.Threading;
using System.Diagnostics;

namespace assignment_2
{
    class Program
    {
        private static int sum = 0;
        private static object _Lock = new object();
        static void plus()
        {
            int i,s = 0;
                for (i = 0; i < 1000001; i++)
                {
                    s += i;
                }
                lock(_Lock)
            {
                sum += s;
            }
        }
        static void minus()
        {
            int i,s = 0;
                for (i = 0; i < 1000001; i++)
                {
                    s -= i;
                }
            lock(_Lock)
            {
                sum += s;
            }
        }
        static void Main(string[] args)
        {
            Thread P = new Thread(new ThreadStart(plus));
            Thread M = new Thread(new ThreadStart(minus));

            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Start...");
            sw.Start();

            P.Start();
            M.Start();

            P.Join();
            M.Join();

            sw.Stop();
            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"Time used: {sw.ElapsedMilliseconds.ToString()} ms");

        }
    }
}