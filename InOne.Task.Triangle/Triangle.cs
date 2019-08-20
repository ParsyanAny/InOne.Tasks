using System;

namespace InOne.Task.Triangle
{
    public class Triangle
    {
        public static void FullTriangle(int n, int k = 1)
        {
            if (n <= 0)
                return;
            else
            {
                for (int i = 0; i <= n; i++)
                {
                    if (i == n)
                    {
                        int tr = k;
                        while (tr != 0)
                        {
                            Console.Write("*");
                            tr--;
                        }
                        k += 2;
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
                FullTriangle(n - 1, k);
            }
        }
        public static void EmptyTriangle(int n, int k)
        {
            if (n <= 2)
                return;
            else
            {
                for (int i = 0; i <= k; i++)
                {
                    if (i == n)
                        Console.Write("*");
                    Console.Write(" ");
                }
                for (int i = k; i >= 0; i--)
                {
                    if (i == n)
                        Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
                EmptyTriangle(n - 1, k);
            }
        }
        public static void DrawTriangle(int n)
        {
            Console.WriteLine(new string(' ', n + 1) + '*');
            EmptyTriangle(n, n);
            Console.Write(" ");
            while (n >= 0)
            {
                Console.Write("*" + " ");
                n--;
            }
        }
    }
}
