using System;
using System.Collections;
namespace InOne.Task
{
    public class QuickCode
    {
        public static void Time(string str, DateTime time) => Console.WriteLine($"\n{str}\nTime = {DateTime.Now - time}");
        public static void Write(char ch, int k) => Console.Write(new string(ch, k) + "\n");
        public static void WriteForeach(IEnumerable enumerable)
        {
            foreach (var item in enumerable)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
