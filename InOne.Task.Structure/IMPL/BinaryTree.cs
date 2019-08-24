using System;
using System.Collections;
using System.Collections.Generic;

namespace InOne.Task.Structure.IMPL
{
    public class BinaryTree<T> : IEnumerable<T>//, IBinaryTree<T>
        where T : IComparable<T>
    {
        private class Node : IComparable<Node>
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
        private int _count = 0;

        public int _Count { get { return _count; } }

        #region Base Functionality
        public void Add(T date)
        {
            Node node = new Node(date);

            if (_root == null)
            {
                _root = node;
                _count++;
            }
            if (_root == node)
            {
                return;
            }
            else if (node._data.CompareTo(_root._data) == -1)
            {
                if (_root == null)
                {
                    _root = node;
                    _count++;


                }
                else
                {
                    _root._left = node;
                    _count++;

                }
            }
            else if (node._data.CompareTo(_root._data) == 1)
            {
                if (_root == null)
                {
                    _root._right = node;
                    _count++;

                }
                else
                {
                    _root._right = node;
                    _count++;

                }
            }
        }
        public T Remove(T node) //????????????
        {
            throw new NotImplementedException();
            _count--;
        }
        public bool Contains(T value) //??????????????????
        {
            return ToString().Contains(value.ToString());
        }
        public T[] ToArray(T[] arr, int count = 0) // ????????????????
        {
            if (count >= _count)
                return arr;
            // T[] arr = new T[_count];
            if (_root._left != null)
                ToArray(arr, count++);
            arr[count] = _root._data;
            if (_root._right != null)
                ToArray(arr, count++);
           return arr;
        }
        public bool IsEmpty(BinaryTree<T> tree) => _root == null;
        public int Count() => _count;

        #region PreOrder, InOrder, PostOrder Write Recursive

        public void PreOrderPrint(T tree)
        {
            Console.Write(_root._data.ToString());
            if (_root._left != null)
                PreOrderPrint(_root._left._data);
            if (_root._right != null)
                PreOrderPrint(_root._right._data);
        }

        public void InOrderPrint(T tree)
        {
            if (_root._left != null)
                InOrderPrint(_root._left._data);
            Console.Write(_root._data.ToString() + "\n");
            if (_root._right != null)
                InOrderPrint(_root._right._data);
        }

        public void PostOrderPrint(T tree)
        {
            if (_root._left != null)
                PostOrderPrint(_root._left._data);
            if (_root._right != null)
                PostOrderPrint(_root._right._data);
            Console.Write(_root._data.ToString());
        }
        #endregion
        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            if (_root._left != null)
                InOrderPrint(_root._left._data);
            yield return _root._data;
            if (_root._right != null)
                InOrderPrint(_root._right._data);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}
