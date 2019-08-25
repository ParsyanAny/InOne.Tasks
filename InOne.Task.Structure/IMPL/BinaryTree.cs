using System;
using System.Collections;
using System.Collections.Generic;

namespace InOne.Task.Structure.IMPL
{
    public class BinaryTree<T> : IEnumerable<T>//, IBinaryTree<T>
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
        public bool Contains(T value)
        {
            var current = _root;
            Node parent = null;

            while (current != null)
            {
                var result = current._data.CompareTo(value);
                if (result > 0)
                {
                    parent = current;
                    current = current._left;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current._right;
                }
                else
                    break;
            }
            return current != null;
        }
        public T Remove(T data) //????????????
        {
            throw new NotImplementedException();
        }
        public T[] ToArray() // ????????????????
        {
            T[] arr = new T[_count];
            return toArray(_root, arr);
        }
        private T[] toArray(Node node, T[] arr)
        {
            int count = 0;
            if (node == null)
                return arr;
            toArray(node._left,arr);
            arr[count]= node._data;
            toArray(node._right,arr);
            arr[count]= node._data;
            count++;
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
        public IEnumerator<T> GetEnumerator(Node node)
        {
            if (node == null)
                yield break;
            GetEnumerator(node._left);
            GetEnumerator(node._right);
            yield return node._data;
        }
        public IEnumerator<T> GetEnumerator() => GetEnumerator(_root);
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
        #endregion 
    }
}
