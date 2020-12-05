using System;
using MySqlConnector;

namespace work12
{
    class Query
    {
        static void Main1(string[] args)
        {
            //1建立数据库连接对象并且建立变量，编写字符串
            string strcon = "data source=localhost;database=xscjdb;user id=root;password=123456;pooling=false;charset=utf8";
            MySqlConnection conn = new MySqlConnection(strcon);
            //2建立数据库操作对象
            MySqlCommand cmd = conn.CreateCommand();
            //3选择数据库表格
            cmd.CommandText = "select *from XSB";
            //4 打开数据库
            conn.Open();
            //5建立查询变量用一个新的类
            MySqlDataReader dr = cmd.ExecuteReader();
            //6判断信息表格信息条数
            if (dr.HasRows)
            {//7挡在读取范围之内时读取出来每一行信息
                while (dr.Read())
                {//8输出
                    string result;
                    result = dr[0].ToString() + dr[1].ToString() + dr[2].ToString() + dr[3].ToString() + dr[4].ToString() + dr[5].ToString();
                    Console.WriteLine(result);
                }
            }
            conn.Close();
            Console.ReadKey();
        }
    }
}
