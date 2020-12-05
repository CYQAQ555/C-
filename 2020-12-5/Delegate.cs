using System;
using System.Collections.Generic;

namespace work13
{
    class Delegate
    {
        static void Main1(string[] args)
        {
            //构造数据
            /* List<Library> stus = new List<Library>();
             Library stu1 = new Library(001, "Thoreau", "Walden");
             Library stu2 = new Library(002, "Thoreau", "Maine");
             Library stu3 = new Library(003, "YuHua", "Alive");
             Library stu4 = new Library(004, "LiuCixin", "Threebody");
             stus.Add(stu1);//添加元素进入集合
             stus.Add(stu2);
             stus.Add(stu3); 
             stus.Insert(0,stu4);//把第四个元素添加到指定位置第零位
             stus.RemoveAt(2);//删除集合中第二个元素
             Console.WriteLine("集合原序：");
             foreach (var stu in stus)
             {
                 Console.WriteLine(stu.No + " " + stu.Writer + " " + stu.Name);
             }
             Console.WriteLine("集合排序后：");
             //这里用委托排序
             stus.Sort(delegate (Library s1, Library s2)
             {
                 if (s1.No != s2.No)
                 {
                     return s1.No.CompareTo(s2.No);
                 }
                 else
                 {
                     if (s1.Writer != s2.Writer)
                     {
                         return s1.Writer.CompareTo(s2.Writer);
                     }
                     else
                     {
                         return s1.Name.CompareTo(s2.Name);
                     }
                 }
             });
             foreach (var stu in stus)
             {
                 Console.WriteLine(stu.No + " " + stu.Writer + " " + stu.Name);
             }
             Console.ReadLine();
         }
     }
     public class Library
     {
         public int No;
         public string Writer;
         public string Name;
         public Library(int no, string writer, string name)
         {
             No = no;
             Writer = writer;
             Name = name;
         }
     }*/
        }
    }
}

