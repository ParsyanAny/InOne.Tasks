using System;
using System.Collections.Generic;
using System.Text;

namespace InOne.Task.Shapes
{
    public class Triangle
    {
        public static void FullTriangleRec(int n, int k = 1)
        {
            if (n <= 0)
                return;

            int a = 0;
            if (n != a)
            {
                QuickCode.Write(' ', n);
                a = n;
            }
            QuickCode.Write('*', k);
            Console.WriteLine();
            FullTriangleRec(n - 1, k + 2);
        }
        public static void FullTriangle(int n, int k = 1)
        {
            if (n <= 0)
                return;
            for (int i = 0; i <= n; i++)
            {
                if (i == n)
                {
                    QuickCode.Write('*', k);
                    k += 2;
                }
                Console.Write(" ");
            }
            Console.WriteLine();
            FullTriangle(n - 1, k);
        }
        public static void EmptyTriangleRec(int n, int k = 0)
        {
            if (n <= 0)
                return;
            if( k == n)
                Console.Write('*');
            Console.Write(' ');
            EmptyTriangleRec(n, k + 1);
            EmptyTriangleRec(n - 1, k = n);
        }
        public static void EmptyTriangle(int n, int k)
        {
            if (n <= 2)
                return;
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
        public static void DrawTriangleRec(int n)
        {
            Console.WriteLine(new string(' ', n + 1) + '*');
            EmptyTriangleRec(n);
            Console.Write(" ");
            while (n >= 0)
            {
                Console.Write("*" + " ");
                n--;
            }
        }
    }
}
