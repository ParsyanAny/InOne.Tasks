using System;
using System.Collections.Generic;
using System.Text;

namespace InOne.Task.Algorithms
{
    public class Recursive
    {
        public static int FibonachiSlow(int number)
        {
            if (number == 0)
                return 0;
            if (number == 1)
                return 1;
            return FibonachiSlow(number - 2) + FibonachiSlow(number - 1);
        }
        public static int FibonachiFast(int number, int first = 0, int second = 1)
        {
            if (number == 0)
                return first;
            int temp = first;
            return FibonachiFast(number - 1, first = second, second = temp + second);
        }

    }
}
