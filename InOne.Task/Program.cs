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
            #region Structures
            #region MyLinkedList
            //MyLinkedList<int> list = new MyLinkedList<int>() { 1, 2, 3, 4, 5 };
            //list.Reverse();
            //list.RemoveLast();
            //list.Add(7);
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
            //list.ForeachWrite();
            #endregion

            #region ArrayQueue
            //ArrayQueue<int> arq = new ArrayQueue<int>(5);
            //arq.Enqueue(1);
            //arq.Enqueue(2);
            //arq.Enqueue(3);
            //arq.Enqueue(4);
            //arq.Enqueue(5);
            //arq.Enqueue(5);
            //arq.Reverse();
            //arq.ForeachWrite();
            #endregion

            #region ArrayStack
            //ArrayStack<int> ars = new ArrayStack<int>(3);
            //ars.Push(1);
            //ars.Push(2);
            //ars.Push(3);
            //ars.Pop();
            //ars.Reverse();
            //Console.WriteLine(ars.Pop());
            //ars.ForeachWrite();
            #endregion

            #region LinkedQueue
            //LinkedQueue<int> queue = new LinkedQueue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Dequeue();
            //queue.ForeachWrite();
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
            //st.Reverse();
            //st.ForeachWrite();
            //  st.Peek();
            #endregion
            #endregion

            #region BigInteger
            //var bigI = new BigInteger();
            //BigInteger bigI1 = new BigInteger(-10);
            //BigInteger bigI2 = new BigInteger(10);
            //bigI = bigI1.Sum(bigI2);
            //Console.WriteLine(bigI.Sign);
            //foreach (var item in bigI)
            //{
            //    Console.WriteLine(item);
            //}
            //MyLinkedList<int> to = new MyLinkedList<int>();
            //to.Add(4);
            //to.Add(5);
            //to.Add(5);

            // int a = bigI1.Compare(to);
            //Console.WriteLine(a);
            //BigInteger bigI2 = new BigInteger(97);
            //bigI = bigI.Factorial(5);
            //bigI.Reverse();
            //BigInteger muli = bigI1.Multiplication(bigI2);

            ////BigInteger sum = bigI1.Sum(3);

            ////BigInteger mul = bigI1.Multiplication(muli);

            //foreach (var item in to)
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

            //int number = 44;
            //var b = Iterative.Palindrome(number);

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
            //Recursive.TowerOfHanoi(tower1, tower2, tower3, tower1.Count());
            //foreach (var item in tower3)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] arr = new int[]{ 1, 2, 3, 4, 5, 10, 25,6, 3, 2, 1, 0, - 1, - 2, - 3, - 4, - 5, - 6 };
            //int index = Iterative.MaxPointIndex(arr);
            //Console.WriteLine(index);

            //int[] arr = {1,1,2,2,3,3,6,6,7,7,9,11,11,15,15};
            //int a = Iterative.SingleElement(arr);
            //Console.WriteLine(a);
            #endregion

            #region Sorting

            //int[] arr = {5,6,2,1,4,44,5,3,21,54,5,6};
            //QuickCode.WriteForeach(arr);
            //Sort<int>.InsertionSort(arr);
            //Sort<int>.BubbleSort(arr);
            //Sort<int>.SelectionSort(arr);
            //QuickCode.WriteForeach(arr);

            #endregion

            #region Triangle
            //Triangle.DrawTriangleRec(60);
            #endregion

            #region Binary tree
            //BinaryTree<int> bt = new BinaryTree<int>()
            //{
            //    2,
            //    20,
            //    10,
            //    -5,
            //    -8,
            //    1
            //};
            //foreach (var item in bt)
            //{
            //    Console.WriteLine(item);
            //}
            //int count = bt._Count;
            //bt.Remove(2);
            //Console.WriteLine(count);
            //bt.PreOrderPrint();
            //Console.WriteLine();
            //bt.InOrderPrint();
            //Console.WriteLine();
            //bt.Remove(1);
            //bt.InOrderPrint();
            //Console.WriteLine();
            //bt.PostOrderPrint();
            //bool res = bt.Contains(22);
            //Console.WriteLine(res);
            //var arr = bt.ToArray();
            //foreach (var item in bt)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Binary Search Tree
            //BinarySearchTree<int> bst = new BinarySearchTree<int>();// { 10,2,30,5,9,2,99,0,25,98 };
            BinarySearchTreeAVL<int> bst = new BinarySearchTreeAVL<int>();// { 10,2,30,5,9,2,99,0,25,98 };
            bst.Add(1);
            //bst.Add(-5);
            //bst.Add(-65);
            bst.Add(2);
            bst.Add(3);
            //bst.Add(5);
            //bst.Add(1);

            bst.InOrderPrint();
            //bst.ForeachWrite();
            //bst.Add(13);

            //var arr = bst.ToArray();
            //arr.ForeachWrite();
            //bst.InOrderPrint();
            //bst.Remove(5);
            //bst.InOrderPrint();
            //bst.InOrderPrint();
            //Console.WriteLine();
            //bst.InOrderPrint();
            //bst.PreOrderPrint();
            //Console.WriteLine(aa.Contains(20)); 
            //Console.WriteLine(aa.Count());
            #endregion

            Console.ReadLine();
        }
    }
}

