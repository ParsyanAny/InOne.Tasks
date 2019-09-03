using System;

namespace InOne.Task
{
    public class Tester
    {
        public static void Time(string str, DateTime time) => Console.WriteLine($"\n{str}\nTime = {DateTime.Now - time}");
        public static void Write(char ch, int k) => Console.Write(new string(ch, k) + "\n");
    }
}
