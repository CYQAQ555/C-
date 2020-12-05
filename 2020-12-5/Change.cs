using System;
using MySqlConnector;

namespace work12
{
    class Change
    {
        static void Main(string[] args)
        {
            Console.Write("请输入要修改的学生姓名：");
            string StuOName = Console.ReadLine();
            Console.Write("请输入修改后的学生姓名：");
            string StuNName = Console.ReadLine();

            //1、创建数据库连接类
            string strcon = "data source=localhost;database=xscjdb;user id=root;password=123456;pooling=false;charset=utf8";
            MySqlConnection conn = new MySqlConnection(strcon);

            //2、创建数据库操作类
            MySqlCommand cmd = conn.CreateCommand();

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
