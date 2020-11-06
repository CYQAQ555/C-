using System;

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            //输入十进制数d，利用Parse方法将字符串类型强制转换成int类型来输入
            Console.WriteLine(Convert.ToString(i, 16));
            /*将输入的十进制数d转为16进制字符串；
             其中Convert.ToString(int value, int toBase)
            可以把一个数字（十进制）转换为不同进制数值的字符串格式,
　　　　　　value 参数 要进行转换的数字（十进制数）
            toBase参数 要转换成的进制格式，只能是2、8、10及16。*/
        }
    }
}
