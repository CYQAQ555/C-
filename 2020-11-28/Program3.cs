using System;
using System.Diagnostics;

namespace work10
{       
        public class InsertionSorter//插入排序
        {
            public int[] list;
            public void Sort1()
            {
                for (int i = 1; i < list.Length; i++)
                {
                    int t = list[i];
                    int j = i;
                    while ((j > 0) && (list[j - 1] > t))
                    {
                        list[j] = list[j - 1];
                        --j;
                    }
                    list[j] = t;
                }
                Console.WriteLine("Insertion done.");
            }
        }
        public class BubbleSorter//冒泡排序
        {
            public int[] list;
            public void Sort2()
            {
                int i, j, temp;
                bool done = false;
                j = 1;
                while ((j < list.Length) && (!done))
                {
                    done = true;
                    for (i = 0; i < list.Length - j; i++)
                    {
                        if (list[i] > list[i + 1])
                        {
                            done = false;
                            temp = list[i];
                            list[i] = list[i + 1];
                            list[i + 1] = temp;
                        }
                    }
                    j++;
                }
                Console.WriteLine("Bubble done.");
            }
        }
        public class SelectionSorter//选择排序
        {
            private int min;
            public int[] list;
            public void Sort3()
            {
                for (int i = 0; i < list.Length - 1; i++)
                {
                    min = i;
                    for (int j = i + 1; j < list.Length; j++)
                    {
                        if (list[j] < list[min])
                            min = j;
                    }
                    int t = list[min];
                    list[min] = list[i];
                    list[i] = t;
                }
                Console.WriteLine("Selection done.");
            }
        }
        class Mainclass
        {
            static void Main(string[] args)
            {
                InsertionSorter Sorter1 = new InsertionSorter();
                BubbleSorter Sorter2 = new BubbleSorter();
                SelectionSorter Sorter3 = new SelectionSorter();
                //生成随机元素的数组
                int iCount = 10000;
                Random random = new Random();
                Sorter1.list = new int[iCount];
                Sorter2.list = new int[iCount];
                Sorter3.list = new int[iCount];
                for (int i = 0; i < iCount; ++i)
                {
                    Sorter1.list[i] = Sorter2.list[i] = Sorter3.list[i] = random.Next();
                }
                Stopwatch stwatch = new Stopwatch();
                stwatch.Start();
                //单线程运行
                Sorter1.Sort1();
                Sorter2.Sort2();
                Sorter3.Sort3();
                Sorter1.Sort1();
                Sorter2.Sort2();
                Sorter3.Sort3();
                stwatch.Stop();
                Console.WriteLine(stwatch.Elapsed.TotalMilliseconds);
                Console.ReadKey();
            }
        }
}