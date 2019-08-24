using InOne.Task.Structure.IMPL;
using InOne.Task.Algorithms;
using InOne.Task.Shapes;
using System;
using System.Collections.Generic;

namespace InOne.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test Structures
            //MyLinkedList<int> list = new MyLinkedList<int>() { 2, 3, 4, 6, 7, 8, 9 };
            //list.AddFirst(1);
            //list.AddLast(10);
            //list.Add(11);
            //list.RemoveFirst();
            //list.RemoveById(2);
            //list.InsertById(3, 5);
            //var count = list.Count();
            //Console.WriteLine($"Count = {count} \n");
            //var isEmpty = list.IsEmpty();
            //Console.WriteLine($"IsEmpty = {isEmpty} \n");

            //Console.WriteLine("This is a normal list");
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            #region ArrayQueue

            #endregion
            #region ArrayStack
            //ArrayStack<int> arrSt = new ArrayStack<int>(15);
            //arrSt.Push(1);
            //arrSt.Push(2);
            //arrSt.Push(3);
            //arrSt.Pop();
            //ArrayStack<int> ar = new ArrayStack<int>(5);
            //ar.Push(222);
            //ar.Push(555);
            //ar.Push(666);
            #endregion
            #region LinkedQueue
            //LinkedQueue<int> q = new LinkedQueue<int>();
            //q.Enqueue(6);
            #endregion
            #region LinkedStack
            //LinkedStack<int> ls = new LinkedStack<int>();
            //ls.Push(5);
            //ls.Push(6);
            //ls.Push(7);
            //LinkedStack<string> st = new LinkedStack<string>();
            //st.Push("A");
            //st.Push("B");
            //st.Push("C");
            #endregion
            //Console.WriteLine(q.Dequeue());
            #endregion
            #region BigInteger
            //var bigI = new BigInteger();
            //BigInteger bigI1 = new BigInteger(200);
            //BigInteger muli = new BigInteger(3);
            //BigInteger sum = bigI1.Sum(22);
            //BigInteger mul = bigI1.Multiplication(muli);
            //list = bigI.Sum(25,8);
            ////list = bigI.Subtraction(5000,4999);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Algorithms
            //int a = Iterative.Fibonachi(10);

            //var time1 = DateTime.Now;
            //int slow = Recursive.FibonachiSlow(10);
            //QuickCode.Time("Slow Fibonachi", time1);

            //var time2 = DateTime.Now;
            //int fast = Recursive.FibonachiFast(10);
            //QuickCode.Time("Fasst Fibonachi", time2);

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //int index1 = Iterative.BinarySearch(list, 1);
            //int index2 = Recursive.BinarySearch(list, 20, list.Count - 1, 0);
            //Console.WriteLine(index1);

            //int a = Recursive.BinaryNumber(50);
            //int a = 49;
            //Console.WriteLine(Math.Sqrt(a));
            //Console.WriteLine(qm);
            //ArrayStack<int> tower1 = new ArrayStack<int>(3);
            //ArrayStack<int> tower2 = new ArrayStack<int>(3);
            //tower1.Push(3);
            //tower1.Push(2);
            //tower1.Push(1);
            //ArrayStack<int> tower3 = new ArrayStack<int>(3);
            //Recursive.TowerOfHanoi(tower1,tower2,tower3, tower1.Count());


            //int[] arr = new int[]{ 1, 2, 3, 4, 5, 10, 25,6, 3, 2, 1, 0, - 1, - 2, - 3, - 4, - 5, - 6 };
            //int index = Iterative.MaxPointIndex(arr);
            //Console.WriteLine(index);
            #endregion
            #region Triangle
            //Triangle.DrawTriangleRec(60);
            #endregion
            #region Binary tree
            //BinaryTree<int> bt = new BinaryTree<int>
            //{
            //    2,
            //    20,
            //    10,
            //    -5,
            //    -8,
            //    1
            //};
            //string str = bt.ToString();
            //bool a =  bt.Contains(-5);
            //Console.WriteLine(str);
            //var arr = new int[6];
            //bt.ToArray(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //bt.InOrderPrint(bt);
            #endregion
            int number = 55152515;
            // int log = MyMath.IntLog10(number);
            // int first = number / MyMath.Pow10(log);
            // int last = number % 10;
            // //int number2 = number /MyMath.Pow10(log + 1);
            // //int number2 = number - ((int)(number / Math.Pow(10, log * Math.Pow(10,log))));
            // int number2 = number - (number / MyMath.Pow10(log) * MyMath.Pow10(log));
            //// number2 = (number2 / 10);

            // Console.WriteLine(number2);
            // Console.WriteLine($"first is {first}");
            // Console.WriteLine($"last is {last}");
            // Console.WriteLine($"log {log}");
            // Console.WriteLine(number);
            //  Console.WriteLine(a);
            var b = Iterative.Palindrome(number);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
    
