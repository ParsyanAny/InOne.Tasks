using System;
using System.Collections;
namespace InOne.Task
{
    public static class Extentions
    {
        public static void ForeachWrite(this IEnumerable enumerable)
        {
            foreach (var item in enumerable)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
