using System;

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
        public static void EmptyTriangleRec(int n, int skip = 1)
        {
            if (n == 2)
                return;

            QuickCode.Write(' ', n);
            Console.Write("*");
            QuickCode.Write(' ',skip);
            Console.Write("*");
            Console.WriteLine();

            EmptyTriangleRec(n-1, skip + 2);
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
            QuickCode.Write(' ',n+1);
            Console.WriteLine("*");
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
