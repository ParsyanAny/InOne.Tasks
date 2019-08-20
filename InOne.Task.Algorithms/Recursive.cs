﻿using System.Collections.Generic;

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
        public static int BinaryNumber(int number)
        {
            if (number == 0)
                return 0;
            else
                return (number % 2 + 10 * BinaryNumber(number / 2));
        }
        public static int BinarySearch(List<int> list, int number, int maxIndex, int minIndex)
        {
            if (minIndex > maxIndex)
            {
                return 0;
            }
            int mid = (minIndex + maxIndex) / 2;
            if (number == list[mid])
            {
                return mid;
            }
            else if (number < list[mid])
            {
                return BinarySearch(list, number, maxIndex = mid - 1, minIndex);
            }
            else
            {
                return BinarySearch(list, number, maxIndex, minIndex = mid + 1);
            }
        }
    }
}

