using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOne.Task
{
    public class QuickCode
    {
        public static void Time(string str, DateTime time)
        {
            Console.WriteLine($"\n{str}\nTime = {DateTime.Now - time}");
        }
        //public static int MathSqrtInt(int number, int count = 0)
        //{
        //    if (number == 0)
        //        return count;
        //    return MathSqrtInt(number / 2, ++count);
        //}
    }
}
