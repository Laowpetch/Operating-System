using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Problem01
{
    class Program
    {
        static byte[] Data_Global = new byte[1000000000];
        static long sum_G = 0;
        static int ReadData()
        {
            int returnData = 0;
            FileStream fs = new FileStream("Problem01.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            try 
            {
                Data_Global = (byte[]) bf.Deserialize(fs);
            }
            catch (SerializationException se)
            {
                Console.WriteLine("Read Failed:" + se.Message);
                returnData = 1;
            }
            finally
            {
                fs.Close();
            }
            return returnData;
        }
        static void sum1()
        {
            int sum = 0,i = 0;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            }
            sum_G += sum;  
        }
        static void sum2()
        {
            int sum = 0,i = 1;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            } 
            sum_G += sum; 
        }
        static void sum3()
        {
            int sum = 0, i = 2;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            }  
            sum_G += sum; 
        }
        static void sum4()
        {
            int sum = 0,i = 3;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            }  
            sum_G += sum; 
        }
        static void sum5()
        {
            int sum = 0,i = 4;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            }  
            sum_G += sum; 
        }
        static void sum6()
        {
            int sum = 0,i = 5;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            }  
            sum_G += sum; 
        }
        static void sum7()
        {
            int sum = 0,i = 6;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            }  
            sum_G += sum; 
        }
        static void sum8()
        {
            int sum = 0,i = 7;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            }  
            sum_G += sum; 
        }
        static void sum9()
        {
            int sum = 0,i = 8;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            }
            sum_G += sum;  
        }
        static void sum10()
        {
            int sum = 0,i = 9;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            }
            sum_G += sum;   
        }
        static void sum11()
        {
            int sum = 0,i = 10;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            }
            sum_G += sum;   
        }
        static void sum12()
        {
            int sum = 0,i = 11;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            } 
            sum_G += sum; 
        }
        static void sum13()
        {
            int sum = 0,i = 12;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            }
            sum_G += sum;   
        }
        static void sum14()
        {
            int sum = 0,i = 13;
            for(; i<1000000000;i+=14)
            {
            int x = Data_Global[i];
            if (x % 2 == 0)
            {
                sum -= x;
            }
            else if (x % 3 == 0)
            {
                sum += (x*2);
            }
            else if (x % 5 == 0)
            {
                sum += (x / 2);
            }
            else if (x % 7 == 0)
            {
                sum += (x / 3);
            }
            Data_Global[i] = 0;
            }
            sum_G += sum;  
        }

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            Thread th1 = new Thread(sum1);
            Thread th2 = new Thread(sum2);
            Thread th3 = new Thread(sum3);
            Thread th4 = new Thread(sum4);
            Thread th5 = new Thread(sum5);
            Thread th6 = new Thread(sum6);
            Thread th7 = new Thread(sum7);
            Thread th8 = new Thread(sum8);
            Thread th9 = new Thread(sum9);
            Thread th10 = new Thread(sum10);
            Thread th11 = new Thread(sum11);
            Thread th12 = new Thread(sum12);
            Thread th13 = new Thread(sum13);
            Thread th14 = new Thread(sum14);
            /* Read data from file */
            Console.Write("Data read...");
            if (ReadData() == 0)
            {
                Console.WriteLine("Complete.");
            }
            else
            {
                Console.WriteLine("Read Failed!");
            }
            /* Start */
            Console.Write("\n\nWorking...");
            sw.Start();
            th1.Start();
            th2.Start();
            th3.Start();
            th4.Start();
            th5.Start();
            th6.Start();
            th7.Start();
            th8.Start();
            th9.Start();
            th10.Start();
            th11.Start();
            th12.Start();
            th13.Start();
            th14.Start();
            th1.Join();
            th2.Join();
            th3.Join();
            th4.Join();
            th5.Join();
            th6.Join();
            th7.Join();
            th8.Join();
            th9.Join();
            th10.Join();
            th11.Join();
            th12.Join();
            th13.Join();
            th14.Join();
            // sum();
            sw.Stop();
            Console.WriteLine("Done.");

            /* Result */
            Console.WriteLine("Summation result: {0}", sum_G);
            Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
        }
    }
}