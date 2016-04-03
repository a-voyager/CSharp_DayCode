using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCode
{
    class ClassT
    {
        public static void test<T>()
            where T : class //约束为引用类型
        {

        }

        static void Main2(string[] args)
        {
            test<string>();
        }
    }

    class ListTest {
        static void Main3(string[] args)
        {
            #region 列表
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            foreach (var item in list)
            {
                //Console.WriteLine(item);
            }
            #endregion

            #region 字典
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("A", "a");
            //Console.WriteLine(d["A"]);

            foreach (var item in d)
            {
                //Console.WriteLine(item.Value);
            }

            #endregion

        }
    }

}
