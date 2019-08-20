using System;
using System.Collections.Generic;
using System.Text;

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
            throw new Exception("Number not found");
        }
    }
}
