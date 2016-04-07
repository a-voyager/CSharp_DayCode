using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DayCode
{
    class ThreadClass
    {



        public void test() { lock ("") { } }

        static void Main1(string[] args)
        {
            Thread t = new Thread(() => { while (true) { Console.WriteLine("Hello"); Thread.Sleep(1000); } });
            t.IsBackground = false; //是否为后台 为后台时，程序退出则结束线程 否则继续线程
            t.Start();


        }
    }
}
