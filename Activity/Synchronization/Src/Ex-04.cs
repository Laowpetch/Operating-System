using System;
using System.Threading;

namespace assignment_2
{
    class Program4
    {
        private static string x = "";
        private static int exitflag = 0;
        static void ThReadX()
        {
            while (exitflag == 0)
                Console.WriteLine($"X = {x}");
        }
        static void ThWriteX()
        {
            string xx;
            while (exitflag == 0)
            {
                Console.Write("Input: ");
                xx = Console.ReadLine();
                if (xx == "exit")
                    exitflag = 1;
                else
                    x = xx;
            }
        }
        static void Main(string[] args)
        {
            Thread A = new Thread(ThReadX);
            Thread B = new Thread(ThWriteX);

            A.Start();
            B.Start();
        }
    }
}