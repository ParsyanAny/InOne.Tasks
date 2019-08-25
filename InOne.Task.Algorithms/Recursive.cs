using System.Collections.Generic;
using InOne.Task.Structure.IMPL;

namespace InOne.Task.Algorithms
{
    public class Recursive
    {
        public static int Factorial(int num) => num == 0 ? 1 : num * Factorial(num - 1);
        public static int FibonachiSlow(int num)
        {
            if (num == 0)
                return 0;
            if (num == 1)
                return 1;
            return FibonachiSlow(num - 2) + FibonachiSlow(num - 1);
        }
        public static int FibonachiFast(int num, int first = 0, int second = 1)
        {
            if (num == 0)
                return first;
            int temp = first;
            return FibonachiFast(num - 1, first = second, second = temp + second);
        }
        public static int BinaryNumber(int num) => num == 0 ? 0 : num % 2 + 10 * BinaryNumber(num / 2);
        public static int BinarySearch(List<int> list, int num, int maxIndex, int minIndex)
        {
            if (minIndex > maxIndex)
            {
                return 0;
            }
            int mid = (minIndex + maxIndex) / 2;
            if (num == list[mid])
            {
                return mid;
            }
            else if (num < list[mid])
            {
                return BinarySearch(list, num, maxIndex = mid - 1, minIndex);
            }
            else
            {
                return BinarySearch(list, num, maxIndex, minIndex = mid + 1);
            }
        }
        public static void TowerOfHanoi(ArrayStack<int> tower1, ArrayStack<int> tower2, ArrayStack<int> tower3, int count)
        {
            //if (count == 1)
            //{
            //    tower3.Push(tower1.Pop());
            //    return;
            //}

            //TowerOfHanoi(tower1, tower2, tower3, count - 1);

            //tower3.Push(tower1.Pop());

            //TowerOfHanoi(tower1, tower2, tower3, count - 1);
        }
    }
}


