using System;
using System.Threading;

namespace assignment_2
{
    class Program
    {
        private static string x = "";
        private static int exitflag = 0;
        private static int updateFlag = 0;
        private static object _Lock = new object();

        static void ThReadX(object i)
        {
            while (exitflag == 0)
            {
                lock(_Lock)
                {
                    if (x != "" && updateFlag == 1)
                    {
                        Console.WriteLine($"***Thread {i} : x = {x}***");
                        updateFlag = 0;
                        x = "";
                    }
                }
            }
            Console.WriteLine($"---Thread {i} exit---");
        }
        static void ThWriteX()
        {
            string xx;
            while (exitflag == 0)
            {
                if(x == "")
                {
                updateFlag = 1;
                Console.Write("Input: ");
                xx = Console.ReadLine();
                if (xx == "exit")
                    exitflag = 1;
                else
                    x = xx;
                }
            }
        }
        static void Main(string[] args)
        {
            Thread A = new Thread(ThWriteX);
            Thread B = new Thread(ThReadX);
            Thread C = new Thread(ThReadX);
            Thread D = new Thread(ThReadX);

            A.Start();
            B.Start(1);
            C.Start(2);
            D.Start(3);
        }
    }
}