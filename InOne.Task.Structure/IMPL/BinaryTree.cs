using System;
using System.Collections;
using System.Collections.Generic;

namespace InOne.Task.Structure.IMPL
{
    public class BinaryTree<T> : IEnumerable<T>, IBinaryTree<T>
        where T : IComparable<T>
    {
        public class Node : IComparable<Node>
        {
            public Node _left = null;
            public Node _right = null;
            public Node _parent = null;
            public T _data;
            public Node(T data)
            {
                _data = data;
            }
            public int CompareTo(Node other)
            {
                return _data.CompareTo(other._data);
            }
        }
        private BinaryTree<Node> leftTree;
        private BinaryTree<Node> rightTree;
        private Node _root = null;
        private Node _current = null;
        private int _count = 0;

        public int _Count { get { return _count; } }

        #region Base Functionality (Add, Contains, ToArray, IsEmpty, Count)
        public void Add(T data)
        {
            Node newNode = new Node(data);
            Node trPar = null;

            if (_root == null)
            {
                _root = newNode;
                _count++;
            }
            else
            {
                _current = _root;
                while (true)
                {
                    trPar = _current;
                    if (data.CompareTo(_current._data) == -1)
                    {
                        _current = _current._left;
                        if (_current == null)
                        {
                            trPar._left = newNode;
                            newNode._parent = trPar;
                            _count++;
                            return;
                        }
                    }
                    else
                    {
                        _current = _current._right;
                        if (_current == null)
                        {
                            trPar._right = newNode;
                            newNode._parent = trPar;
                            _count++;
                            return;
                        }
                    }
                }
            }
        }
        public T Remove(T data) //????????????
        {
            throw new NotImplementedException();
        }
        public bool Contains(T value) //??????????????????
        {
            return ToString().Contains(value.ToString());
        }
        public T[] ToArray() // ????????????????
        {
            int count = 0;
            T[] arr = new T[this._Count];
            foreach (T item in this)
            {
                arr[count] = item;
                count++;
            }
            return arr;
        }
        public int Count() => _count;
        public bool IsEmpty(IBinaryTree<T> tree) => _root == null;
        #endregion

        #region PreOrder, InOrder, PostOrder Write Recursive
        public void PreOrderPrint() => printPreOrder(_root);
        public void InOrderPrint() => printInOrder(_root);
        public void PostOrderPrint() => printPostOrder(_root);

        #region Private Part
        private void printInOrder(Node node)
        {
            if (node == null)
                return;
            printInOrder(node._left);
            Console.Write(node._data + " ");
            printInOrder(node._right);
        }
        private void printPostOrder(Node node)
        {
            if (node == null)
                return;
            printInOrder(node._left);
            printInOrder(node._right);
            Console.Write(node._data + " ");
        }
        private void printPreOrder(Node node)
        {
            if (node == null)
                return;
            Console.Write(node._data + " ");
            printInOrder(node._left);
            printInOrder(node._right);
        }
        #endregion
        #endregion

        #region IEnumerable IMPL
        public IEnumerator<T> GetEnumerator() // ????
        {
            throw new NotImplementedException();
            //return EnumerableImpl(_root);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion 
    }
}
