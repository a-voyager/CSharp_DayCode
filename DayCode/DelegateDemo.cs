using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCode
{
    /// <summary>
    /// 委托
    /// 一种数据类型 针对于方法
    /// </summary>
    class DelegateDemo
    {

        private static int Add(int a, int b) { return a + b; }
        private static int Sub(int a, int b) { return a - b; }
        private static int print(int a, int b) { Console.WriteLine("Hello World"); return 0; }

        static void Main1(string[] args)
        {

            //DelegateAdd d = new DelegateAdd(Add); //可以简化
            DelegateAdd d = Add;
            d += Sub;   //内含集合 可包含多个指向方法的指针 方法的签名格式一定要一样才可以指向
            d -= Add;
            d += print; //有多个返回值时 返回值为最后一次的返回值
            Console.WriteLine(d(1, 2));

            // 等价于
            Add(1, 2);

            // 委托的作用
            // 指向方法

            // 系统已经定义的委托
            // Action 表示无返回值的委托类型
            // Func<T> 表示有返回值的委托类型 返回值是T类型

        }
    }

    public delegate int DelegateAdd(int a, int b);

}
