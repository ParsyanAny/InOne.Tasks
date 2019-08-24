using System;
using System.Collections.Generic;

namespace InOne.Task.Algorithms
{
    public class Iterative
    {
        public static int Fibonachi(int number)
        {
            int first = 0;
            int second = 1;
            for (int i = 0; i < number; i++)
            {
                int temp = first;
                first = second;
                second = temp + second;
            }
            return first;
        }
        public static int BinarySearch(List<int> list, int number)
        {
            if (list.Count == 0)
                throw new Exception("List is Empty");
            int minIndex = 0;
            int maxIndex = list.Count - 1;
            while (minIndex <= maxIndex)
            {
                int mid = (minIndex + maxIndex) / 2;
                if (number == list[mid])
                {
                    return mid;
                }
                else if (number < list[mid])
                {
                    maxIndex = mid - 1;
                }
                else
                {
                    minIndex = mid + 1;
                }
            }
            return -1;
        }
        public static bool Palindrome(int number)  // Task
        {
            int log = MyMath.IntLog10(number);
            while (number >= 10)
            {
                if ((number / MyMath.Pow10(log)) != number % 10)
                    return false;
                number = number - (number / MyMath.Pow10(log) * MyMath.Pow10(log));
                number /= 10;
                log -= 2;
                
            }
            return true;
        }
        public static int MaxPointIndex(int[] arr)
        {
            if (arr.Length < 3)
                throw new Exception("Array is too small");
            int min = 0;  // 1 2 3 4 5 10 25 6 3 2 1 0 - 1 - 2 - 3 - 4 - 5 - 6
            int max = arr.Length - 1;
            while (min <= max)
            {
                int mid = (max + min) / 2;
                if (arr[mid - 1] < arr[mid] && arr[mid + 1] < arr[mid])
                    return mid;
                else if (arr[mid] > arr[mid + 1])
                    max = mid - 1;
                else if (arr[mid] < arr[mid + 1])
                    min = mid + 1;
            }
            return int.MinValue;
        }
    }
}
