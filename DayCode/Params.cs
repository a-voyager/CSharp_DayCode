using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCode
{

    class Params
    {
        private static int sum(params int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(sum(1, 2, 3, 4, 5));
            Console.WriteLine(sum());
            Console.ReadLine();
        }
    }
}
