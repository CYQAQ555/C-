using System;
using System.Data.SqlClient;


namespace work11
{
    class Program
    {
        static void Main(string[] args)
        {
            string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            //2建立数据库操作对象
            SqlCommand cmd = conn.CreateCommand();
            //3选择数据库表格
            cmd.CommandText = "select *from XSB";
            //4 打开数据库
            conn.Open();
            //5建立查询变量用一个新的类
            SqlDataReader dr = cmd.ExecuteReader();
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
