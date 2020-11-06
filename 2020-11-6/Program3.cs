using System;
using System.Collections;

namespace work4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = Convert.ToInt32(str);
            ArrayList list = new ArrayList();
            while (n != 0)
            {
                int s = n % 16;//余数                   
                if (s - 10 >= 0)
                {
                    char c = (char)('A' + s - 10);
                    list.Insert(0, c);
                }
                else
                {
                    list.Insert(0, s);
                }
                n = n / 16;//商                           
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
            }
            Console.Read();
        }
    }
}
