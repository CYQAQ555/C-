using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;


namespace work9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //单线程的内容
            Stopwatch stwatch = new Stopwatch();
            stwatch.Start();
            PrintNumb();
            PrintStr();
            PrintNumb();
            PrintStr();
            stwatch.Stop();
            Console.WriteLine(stwatch.Elapsed.TotalMilliseconds);
            Console.ReadKey();*/

            //多线程的内容
            
            Thread readnum = new Thread(new ThreadStart(PrintNumb));
            Thread readstr = new Thread(new ThreadStart(PrintStr));
            Thread readnum1 = new Thread(new ThreadStart(PrintNumb));
            Thread readstr1 = new Thread(new ThreadStart(PrintStr));

            Stopwatch star = new Stopwatch();
            star.Start();
            readnum.Start();
            readstr.Start();
            readnum1.Start();
            readstr1.Start();

            while (true)
            {
                if (readstr.ThreadState == System.Threading.ThreadState.Stopped && readnum.ThreadState == System.Threading.ThreadState.Stopped && readstr1.ThreadState == System.Threading.ThreadState.Stopped && readnum1.ThreadState == System.Threading.ThreadState.Stopped)
                {
                    star.Stop();
                    Console.WriteLine(star.Elapsed.TotalMilliseconds);
                    break;
                }
            }
            Console.ReadKey();
        }
            static void PrintNumb()
            {
                double sum1 = 0.0;
                for (double i = 0; i < 2000000; i += 0.7)
                {
                    sum1 += i;
                }
                Console.WriteLine(sum1);
            }

            static void PrintStr()
            {
                double sum2 = 0.0;
                for (double i = 0; i < 2000000; i += 0.3)
                {
                    sum2 += i;
                }
                Console.WriteLine("输出的是" + sum2.ToString());
            }
        }
}
