using System;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] a = new int[]{1,2,3,6,4,6,7,8,9};//定义一个数组a
			int max = 0;
			for (int i = 0;i < 9;i++)//遍历数组每一个数找出其最大值
			{
				if (a[i] > max)
				{
					max = a[i];//将最大值赋给max
				}
			}
			Console.WriteLine("最大值为{0}",max);
			for (int i = 0;i < 9; i++)//遍历数组找出最大值的下标
            {
				if(a[i] == max)
                {
					Console.WriteLine("其下标为{0}", i);
				}
            }
		}
    }
}
