using System;
using System.Data.SqlClient;

namespace work11
{
    class Change
    {
            static void Main2(string[] args)
            {
                Console.Write("请输入要修改的学生姓名：");
                string StuOName = Console.ReadLine();
                Console.Write("请输入修改后的学生姓名：");
                string StuNName = Console.ReadLine();

                //1、创建数据库连接类
                string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strcon);

                //2、创建数据库操作类
                SqlCommand cmd = conn.CreateCommand();
                //3输入要操作修改的信息
                cmd.CommandText = "update XSB set XM = '" + StuNName + "'  where XM = '" + StuOName + "'";
                //4打开数据库连接
                conn.Open();
                //5引进一个变量来记录受影响条数
                int i = cmd.ExecuteNonQuery();
                //6关闭数据库
                conn.Close();
                //7判断是否能够修改
                if (i > 0)
                    Console.WriteLine("修改成功！");
                else
                    Console.WriteLine("修改失败！");

                Console.ReadKey();
            }
        }
    }