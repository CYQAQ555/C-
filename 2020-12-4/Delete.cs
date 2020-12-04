using System;
using System.Data.SqlClient;

namespace work11
{
    class Delete
    {
        static void Main1(string[] args)
        {
            Console.Write("请输入要删除的学生学号：");
            string StuID = Console.ReadLine();

            //1、创建数据库连接类
            string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);

            //2、创建数据库操作类
            SqlCommand cmd = conn.CreateCommand();
            //3输入要操作删除的信息
            cmd.CommandText = "delete from XSB where XH = '" + StuID + "'";
            //4打开数据库连接
            conn.Open();
            //5引进一个变量来记录受影响条数
            int i = cmd.ExecuteNonQuery();
            //6关闭数据库
            conn.Close();
            //7判断是否能够删除
            if (i > 0)
                Console.WriteLine("删除成功！");
            else
                Console.WriteLine("删除失败！");

            Console.ReadKey();
        }
    }
}