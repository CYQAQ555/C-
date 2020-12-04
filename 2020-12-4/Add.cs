using System;
using System.Data.SqlClient;

namespace work11
{
    class Add
    {
        static void Main3(string[] args)
        {
            Console.Write("请输入学号：");
            string stuId = Console.ReadLine();
            Console.Write("请输入姓名：");
            string StuName = Console.ReadLine();
            Console.Write("请输入性别：");
            string StuSex = Console.ReadLine();
            Console.Write("请输入出生日期：");
            string StuBir = Console.ReadLine();
            Console.Write("请输入专业：");
            string StuMajor = Console.ReadLine();
            Console.Write("请输入总学分：");
            string StuCredit = Console.ReadLine();

            //1、创建数据库连接对象，并编写连接字符串，注意连接字符串不要写错
            string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);

            //2、创建数据库操作对象，创建过程是与刚创建的连接对象匹配起来
            SqlCommand cmd = conn.CreateCommand();

            //3、编写操作语句 TSQL语句
            cmd.CommandText = "insert into XSB(XH,XM,XB,CSRQ,ZY,ZXF) values('" + stuId + "','" + StuName + "','" + StuSex + "','" + StuBir + "','" + StuMajor + "','" + StuCredit + "')";

            //4、数据库连接打开，准备执行操作
            conn.Open();

            //5、执行操作，并记录受影响的行数
            int count = cmd.ExecuteNonQuery();

            //6、关闭数据库连接**********
            conn.Close();

            //7、提示操作是否成功
            if (count > 0)
                Console.WriteLine("添加成功！");
            else
                Console.WriteLine("添加失败！");

            Console.ReadKey();
        }
    }
}
