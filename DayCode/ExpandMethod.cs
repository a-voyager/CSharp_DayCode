using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCode
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    class ExpandMethod
    {
        static void Main1(string[] args)
        {

            #region 扩展方法: 无侵入式的开发
            string str = "123";
            Console.WriteLine(str.ToInt32());
            #endregion

        }
    }

    public static class StringExpand
    {
        public static int ToInt32(this string str)
        {
            return int.Parse(str);
        }
    }

}
