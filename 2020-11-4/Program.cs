using System;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            double p;
            double P = 1d;
            double a, b, c;
            for (int i = 1; i <= n; i++)
            {
                a = 2 * i;
                b = a - 1;
                c = a + 1;
                P *= a / b * a / c;
            }
            p = P * 2;
            Console.WriteLine("Π/2近似"+p);
        }
    }
}
