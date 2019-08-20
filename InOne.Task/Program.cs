using InOne.Task.Structure.IMPL;
using InOne.Task.Algorithms;
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
            //MyLinkedList<int> list = new MyLinkedList<int>();
            //var bigI = new BigInteger();
            //list = bigI.Multiplication(3, 18);
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
            //Time("Slow Fibonachi", time1);

            //var time2 = DateTime.Now;
            //int fast = Recursive.FibonachiFast(10);
            //Time("Fasst Fibonachi", time2);

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //int index = Iterative.BinarySearch(list,201);
            //Console.WriteLine(a);
            #endregion
            Console.ReadLine();
        }
        public static void Time(string str, DateTime time)
        {
            Console.WriteLine($"\n{str}\nTime = {DateTime.Now - time}");
        }
    }
}
    
