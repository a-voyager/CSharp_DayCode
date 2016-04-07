using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCode
{
    /// <summary>
    /// 委托应用 事件
    /// </summary>
    class Event
    {
        static string ToUpper(string str) { return str.ToUpper(); }
        static string ToLower(string str) { return str.ToLower(); }
        static string AddStar(string str) { return str + "♥"; }

        static string DealString(Func<string, string> dealFunc, string str)
        {
            return dealFunc(str);
        }

        static void Main1(string[] args)
        {

            #region usage
            EventClass e = new EventClass();
            //e.HelloEvent += () => { Console.WriteLine("HELLO"); };
            //e.SayHello();
            //Console.ReadLine();
            #endregion

            #region 字符串数组处理

            Console.WriteLine(DealString(ToUpper, "Abc"));
            Console.WriteLine(DealString(ToUpper, "Abc"));
            Console.WriteLine(DealString(AddStar, "Abc"));

            #endregion

        }
    }

    public class EventClass
    {

        // 事件的本质，就是一个委托对象
        // 事件的调用执行只能在类的内部执行
        // 在类的外部只能进行+= -= 操作
        public event Action HelloEvent;     // 事件

        public void Start() { HelloEvent(); }

    }




}
