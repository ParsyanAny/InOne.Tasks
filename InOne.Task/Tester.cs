using System;
using System.Collections;
using System.Collections.Generic;

namespace InOne.Task
{
    public class Tester
    {
        public static void Time(string str, DateTime time) => Console.WriteLine($"\n{str}\nTime = {DateTime.Now - time}");
        public static void Write(char ch, int k) => Console.Write(new string(ch, k) + "\n");
        public int[] GetRandomArray(int count, int min, int max)
        {
            Random rand = new Random();
            int[] arr = new int[count];
            foreach (var item in arr)
            {
                arr[item] = rand.Next(min,max);
            }
            return arr;
        }
        public int[] GetRandomArray(int count) =>  GetRandomArray(count, 0, 100);
    }
}
