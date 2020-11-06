using System;

namespace work5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个字符串："); 
            char[] c = Console.ReadLine().ToCharArray(); //使用ToCharArray()方法将输入的字符串转换为字符数组
            int i = 0, count = 0;
            int a = 0;
            while (i < c.Length)//c.Length为字符串长度，用while循环遍历整个字符串
            {
                if (c[i] >= '0' && c[i] <= '9' && c[i + 1] >= '0' && c[i + 1] <= '9')
                {
                    while (c[i] >= '0' && c[i] <= '9')
                    {
                        i++;
                        if (i == c.Length)
                        {
                            break;
                        }
                    }
                    Console.Write(b[i]);
                    Console.Write(" ");
                    count++;
                }
                if (i < c.Length)
                    i++;
            }
            Console.WriteLine(); 
            Console.WriteLine(count); 
        }
    }
}
