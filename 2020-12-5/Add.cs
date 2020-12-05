using System;
//using MySql.Data.MySqlClient;
using MySqlConnector;


namespace work12
{
    class Add
    {
        static void Main1(string[] args)
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

            //1、创建数据库连接对象，并编写连接字符串，注意连接字符串与SQLServer不同
            string strcon = "data source=localhost;database=xscjdb;user id=root;password=123456;pooling=false;charset=utf8";
            MySqlConnection conn = new MySqlConnection(strcon);
            //mySqlConnection conn = new SqlConnection(strcon);

            //2、创建数据库操作对象，创建过程是与刚创建的连接对象匹配起来
            MySqlCommand cmd = conn.CreateCommand();

            //3、编写操作语句 TSQL语句
            cmd.CommandText = "insert into XSB values('" + stuId + "','" + StuName + "','" + StuSex + "','" + StuBir + "','" + StuMajor + "','" + StuCredit + "')";

            //string sql = "insert into xsb values('" + stuId + "','" + StuName + "' )";
            //MySqlCommand cmd = new MySqlCommand(sql, conn);

            //4、数据库连接打开，准备执行操作
            try { conn.Open(); }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

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