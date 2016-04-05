using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCode
{
    /// <summary>
    /// 引用传递
    /// ref out关键字均为引用传递，相当于传入地址
    /// </summary>
    class RefOut
    {

        private static void fun1(int a) { a++; }
        private static void fun2(ref int a) { a++; }
        private static void fun3(out int a) { a = 10; }

        private static void func1(Person a) { a.print(); }
        private static void func2(ref Person a) { a.name = "func2"; a.print(); }
        private static void func3(out Person a) { a = new Person(); a.print(); }

        static void Main1(string[] args)
        {
            #region 值传递的三种传递方式
            int a = 5;
            fun1(a);
            fun2(ref a);
            fun3(out a);
            //Console.WriteLine("a = " + a);
            #endregion

            #region 引用传递
            Person p = new Person();
            p.name = "zhangsan";
            //func1(p);
            func2(ref p);
            //func3(out p);
            p.print();
            #endregion

            Console.ReadKey();



            // 总结
            // ref 引用传递 函数体可以修改传入参数值
            // out 只将传入参数作为返回值用，传入的参数初始值不会使用到

            // 对于引用类型 无论是值传递还是引用传递，在函数内部对对象的修改，都是有效的
        }

    }

    class Person
    {
        public string name;

        public void print()
        {
            Console.WriteLine("hello"+name);
        }
    }

}
