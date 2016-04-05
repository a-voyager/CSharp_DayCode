using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DayCode
{
    /// <summary>
    /// C#数据库操作
    /// </summary>
    class DB
    {
        static void Main1(string[] args)
        {
            // 第一步: 将MySQL.Datad.dll放到工程.sln同级目录
            // 第二步：“引用”选项中添加引用
            // 第三步：using MySql.Data.MySqlClient

            // 连接描述字符串格式: data source=服务器名称;database=数据库名称;user id=用户名;password=密码;pooling=false;charset=utf8
            string connStr = "data source=localhost;database=数据库名称;user id=用户名;password=密码;pooling=false;charset=utf8";

            #region 查询操作
            // 读取
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = "select * from users";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    if (!reader.IsDBNull(1))
                    {
                        int age = reader.GetInt32("age");
                    }
                }
            }
            #endregion

            #region 插入操作
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string name = "name";
                string pwd = "pwd";

                //string sql = "insert into users(uname, upwd) values('" + name + "','" + pwd + "')";
                string sql = "insert into users(uname, upwd) values(@name, @pwd)";

                MySqlCommand commond = new MySqlCommand(sql, conn);

                commond.Parameters.Add(new MySqlParameter("@name", name));
                commond.Parameters.Add(new MySqlParameter("@pwd", pwd));

                conn.Open();

                // 受影响的行数
                int rowsCount = commond.ExecuteNonQuery();

                if (rowsCount == 1)
                {
                    Console.WriteLine("succeed");
                }
            }
            #endregion

            #region 修改操作

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = "update user set uname='XXX' where id = 5";
                MySqlCommand command = new MySqlCommand(sql, conn);
                conn.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("修改成功");
                }

            }

            #endregion

            #region 删除操作

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = "delete from users where id = 3";
                MySqlCommand command = new MySqlCommand(sql, conn);
                conn.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("删除成功");
                }
            }

            #endregion

        }
    }
}
