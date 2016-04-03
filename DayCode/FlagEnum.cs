using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCode
{

    public enum Number
    {
        One = 10,
        Two,
        Three,
        Four
    }

    public enum Num : byte
    {
        One = 0,
        Two,
        Three,
        Four = 255
    }


    /// <summary>
    /// 标志枚举
    /// 二进制中只有一位为1
    /// </summary>
    [Flags]
    public enum FlagEnum
    {
        red = 1<<0,     //0001
        blue = 1<<1,    //0010
        green = 1<<2    //0100
    }
}
