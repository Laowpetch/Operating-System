using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
namespace experiment_1
{
    class Program
    {
        static int count = 0;
        static int count1 = 0;
        static int count2 = 0;
        static void TestThread1()
        {
            Console.WriteLine("Thread1 Runing...");
            int i;
            for (i = 0; i < 500000000; i++)
            {
                count1++;
                count++;
            }
        }
        static void TestThread2()
        {
            Console.WriteLine("Thread2 Runing...");
            int i;
            for (i = 0; i < 500000000; i++)
            {
                count2++;
                count++;
            }
        }
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Thread thread_1 = new Thread(TestThread1);
            Thread thread_2 = new Thread(TestThread2);
            thread_1.Start();
            thread_2.Start();
            thread_1.Join();
            thread_2.Join();
            sw.Stop();
            Console.WriteLine("Count = {0}",count);
            Console.WriteLine("Count1 = {0}",count1);
            Console.WriteLine("Count2 = {0}",count2);
            Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
        }
    }
}