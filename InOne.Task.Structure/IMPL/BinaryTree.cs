using System;
using System.Collections;
using System.Collections.Generic;

namespace InOne.Task.Structure.IMPL
{
    public class BinaryTree<T> : IEnumerable<T>//, IBinaryTree<T>
        where T : IComparable<T>
    {
        private class Node<T>
            where T : IComparable<T>
        {
            public Node<T> _left = null;
            public Node<T> _right = null;
            public T _data;

            public Node(T data)
            {
                _data = data;
            }
        }
        private Node<T> _root = null;


        #region Base Functionality
        //public void Add(T date)
        //{
        //    Node<T> node = new Node<T>(date);

        //    if (_root == null)
        //    {
        //        _root = node;
        //    }
        //    if (_root == node)
        //    {
        //        return;
        //    }
        //    else if (node._data < _root._data)
        //    {
        //        if (_root == null)
        //        {
        //            _root = node;
        //        }
        //        else
        //        {
        //        }
        //    }
        //    else if (node._data > _root._data)
        //    {
        //        if (_root == null)
        //        {
        //            _root._right = node;
        //        }
        //        else
        //        {
        //        }
        //    }
        //}
        public T Remove(T node)
        {
            throw new NotImplementedException();
        }
        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }

        //public Node<T>[] ToArray(BinaryTree<T> tree)
        //{
        //    Node<T>[] arr = new Node<T>[] { };
        //    arr.GetEnumerator();
        //    return arr;
        //}
        public bool IsEmpty(BinaryTree<T> tree) => _root == null;
        
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
            Console.Write(_root._data.ToString());
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
