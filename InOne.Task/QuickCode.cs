using System;

namespace InOne.Task
{
    public class QuickCode
    {
        public static void Time(string str, DateTime time)
        {
            Console.WriteLine($"\n{str}\nTime = {DateTime.Now - time}");
        }
        public static void Write(char ch, int k)
        {
            Console.Write(new string (ch,k));
            Console.WriteLine();
        }
        //public static int MathSqrtInt(int number, int count = 0)
        //{
        //    if (number == 0)
        //        return count;
        //    return MathSqrtInt(number / 2, ++count);
        //}
    }
}
