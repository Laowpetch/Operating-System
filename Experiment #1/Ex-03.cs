using System;
using System.Threading;
namespace experiment_1
{
    class Program
    {
        static int resource = 10000;
        static void TestThread1()
        {
            resource = 12345;
        }
        static void Main(string[] args)
        {
            Thread thread_1 = new Thread(TestThread1);
            thread_1.Start();
            Thread.Sleep(1);
            Console.WriteLine("resource = {0}", resource);
        }
    }
}