using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            #region 三位水仙花数
            //int a, b, c;
            //for (int i = 100; i < 1000; i++)
            //{
            //    //123
            //    //方法一
            //    a = i / 100;
            //    b = i / 10 % 10;
            //    c = i % 10;
            //    //Console.WriteLine(a + " " + b + " " + c);
            //    //方法二
            //    string str = i.ToString();
            //    //一个字符串可以当作字符数组来看待
            //    a = Convert.ToInt32(str[0].ToString());
            //    b = Convert.ToInt32(str[1].ToString());
            //    c = Convert.ToInt32(str[2].ToString());
            //    //Console.WriteLine(a +" "+ b +" "+ c);

            //    int sum = (int)(Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3));

            //    if (sum == i)
            //    {
            //        // Console.WriteLine(sum);
            //    }

            //}
            #endregion

            #region 数组
            //int[] array = new int[50];
            //Random r = new Random();
            //for (int i = 0; i < 50; i++)
            //{
            //    array[i] = r.Next(1, 10);   //[1, 10) 左闭右开
            //}
            //Console.WriteLine("请输入一个每行显示数字个数：");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int temp = 0; 
            //for (int i = 0; i < 50; i++)
            //{
            //    temp++;
            //    Console.Write(array[i]+" ");
            //    if (temp == num) {
            //        Console.WriteLine("\r\n");
            //        temp = 0;
            //    }
            //}

            #endregion

            #region 时间
            //DateTime t1 = new DateTime(2016, 4, 2, 12, 0, 0);
            //DateTime t2 = DateTime.Now;
            //TimeSpan s = t2 - t1;
            //Console.WriteLine(s.Hours+" "+s.Minutes);
            #endregion

            #region 多态

            Animal c = new Dog(5);
            c.Age = 3;
            bool isAnimal = c is Animal;

            //c.say();

            if (isAnimal)
            {
                Animal a = c as Animal; //转换失败会返回null

                if (a != null)
                {
                    a.say();
                }

            }

            Console.WriteLine(c.Age + " " + isAnimal);

            #endregion

            ////暂停窗口作用
            Console.ReadLine();
        }
    }
}
