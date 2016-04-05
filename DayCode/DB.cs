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
        static void Main(string[] args)
        {
            // 第一步: 将MySQL.Datad.dll放到工程.sln同级目录
            // 第二步：“引用”选项中添加引用
            // 第三步：using MySql.Data.MySqlClient

            #region MySQL操作
            // 读取
            // 连接描述字符串格式: data source=服务器名称;database=数据库名称;user id=用户名;password=密码;pooling=false;charset=utf8
            string connStr = "data source=localhost;database=数据库名称;user id=用户名;password=密码;pooling=false;charset=utf8";
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

        }
    }
}
