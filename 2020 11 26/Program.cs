using System;

namespace work6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double sum = 0.5, t, t1, t2, t3, p = 0.5 * 0.5;
            int odd = 1, even = 2;
            t = t1 = t2 = 1.0;
            t3 = 0.5;
            while (t > 1e-10)
            {
                t1 = t1 * odd / even;
                odd += 2;
                even += 2;
                t2 = 1.0 / odd;
                t3 = t3 * p;
                t = t1 * t2 * t3;
                sum += t;

            }
            Console.WriteLine("\nPI={0,10:f8}", sum * 6);
            Console.Read();
            */
            /*
            double sum = 0.5, t, t1, t2, t3, p = 0.5 * 0.5;
            int odd = 1, even = 2;
            t = t1 = t2 = 1.0;
            t3 = 0.5;
            do
            {
                t1 = t1 * odd / even;
                odd += 2;
                even += 2;
                t2 = 1.0 / odd;
                t3 = t3 * p;
                t = t1 * t2 * t3;
                sum += t;
            }while (t > 1e-10);
            Console.WriteLine("\nPI={0,10:f8}", sum * 6);
            Console.Read();
            */

            double sum = 0.5, t, t1, t2, t3, p = 0.5 * 0.5;
            int odd = 1, even = 2;
            t = t1 = t2 = 1.0;
            t3 = 0.5;
            while (t > 1e-10)
            {
                t1 = t1 * odd / even;
                odd += 2;
                even += 2;
                t2 = 1.0 / odd;
                t3 = t3 * p;
                t = t1 * t2 * t3;
                sum += t;
            }
            Console.WriteLine("\nPI={0,10:f8}", sum * 6);
            Console.Write("请输入圆的半径：");
            string r = Console.ReadLine();
            int R = Convert.ToInt32(r);
            double S = (sum * 6) * R * R;
            Console.WriteLine("\nS={0,10:f8}", S);
            Console.Read();
        }
    }
}
