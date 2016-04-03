using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DayCode
{
    class FileHelper
    {
        static void Main(string[] args)
        {
            #region 文件写操作
            //@可禁用转义字符，也可使用双反斜杠或者正斜杠
            FileStream fs = new FileStream(@"D:\test.text", FileMode.Create, FileAccess.ReadWrite);

            byte[] bs = Encoding.GetEncoding("utf-8").GetBytes("Hello");

            fs.Write(bs, 0, bs.Length);

            //关闭资源 可用using(...){}来自动关闭资源
            fs.Close();
            fs.Dispose();
            #endregion

            #region 读取文件
            using (FileStream ofs = new FileStream("D:\\test.text", FileMode.Open, FileAccess.Read))
            {
                byte[] b = new byte[1024];
                int len;
                while ((len = ofs.Read(b, 0, 1024)) > 0)
                {
                    string str = Encoding.UTF8.GetString(b, 0, len);
                    Console.WriteLine(str);
                }

            }
            #endregion

        }
    }
}
