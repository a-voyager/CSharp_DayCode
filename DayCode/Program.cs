using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            #region 三位水仙花数
            int a, b, c;
            for (int i = 100; i < 1000; i++)
            {
                //123
                //方法一
                a = i / 100;
                b = i / 10 % 10;
                c = i % 10;
                //Console.WriteLine(a + " " + b + " " + c);
                //方法二
                string str = i.ToString();
                //一个字符串可以当作字符数组来看待
                a = Convert.ToInt32(str[0].ToString());
                b = Convert.ToInt32(str[1].ToString());
                c = Convert.ToInt32(str[2].ToString());
                //Console.WriteLine(a +" "+ b +" "+ c);

                int sum = (int)(Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3));

                if (sum == i) {
                    // Console.WriteLine(sum);
                }

            }
            #endregion
            //暂停窗口作用
            Console.ReadLine();
        }
    }
}
