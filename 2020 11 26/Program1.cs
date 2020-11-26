using System;
using System.Net;

namespace work7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ushort x = 60000;
            ushort y = 6789;
            ushort z = (ushort)(x + y);
            Console.WriteLine("Z是:{0}", z);//无符号短整型数取值范围为0~65535,而60000+6789会溢出，溢出的1被丢弃，余下的就是1253
            */
            /* int i1 = 9;
             int i2 = 2;
             float f1 = i1 / i2;
             //i1和i2是整数，故做除法也是以整数形式相除取整，再把取得的4隐式转换赋给浮点型f1
             Console.WriteLine("f1是{0}",f1);
            */
            /* char asc = '1';
             int num1 = 1;
             int num2 = '1';
             Console.WriteLine("asc是{0}，num1是{1},num2是{2}", asc, num1, num2);
             Console.WriteLine("asc的数值是{0}", (int)asc);
            */
            /*float a = 0.1f;
            float b = 0.2f;
            float c = a + b;
            Console.WriteLine("c是{0,10:f9}", c);
            */
            
            byte[] bytes = { 0, 0, 0, 25 };
            int i = BitConverter.ToInt32(bytes, 0);
            //BitConverter.ToInt32();把字节数组中指定位置的四个字节转换成32位整数。
            //以小端模式存储这四个字节“25 0 0 0”转为16进制是“19 00 00 00”,将其合成一个数再转十进制则是“419430400”。
            Console.WriteLine("int:{0}", i);
            //IPAddress.HostToNetworkOrder();将数字从主机字节顺序转换为网络字节顺序，即转换成大端模式
            //以大端模式存储，就将这个数的字节序反转为“0 0 0 25”，合成一个数就为“25”。
            int k = IPAddress.HostToNetworkOrder(i);
            Console.WriteLine("int:{0}", k);
            
        }
    }
}
