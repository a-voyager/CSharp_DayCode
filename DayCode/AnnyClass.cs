using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCode
{
    /// <summary>
    /// 匿名类
    /// </summary>
    class AnnyClass
    {
        // 传统函数做参数方式 适用于多次调用
        static void Say(Action p) { p(); }

        static void PrintHello() { Console.WriteLine("Hello"); }


        static void Main(string[] args)
        {
            Say(PrintHello);
            // 匿名函数 适用于一次性调用
            Say(delegate ()
            {
                Console.WriteLine("Hello Once");
            });

            // Lambda表达式代替
            Say(()=>{
                Console.WriteLine("Hello!");
            });

        }
    }
}
