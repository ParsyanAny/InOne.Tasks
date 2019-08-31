using System;
using System.Collections;
using System.Collections.Generic;

namespace InOne.Task.Structure.IMPL
{
    public class BinarySearchTree<T> : IBinarySearchTree<T> // , IEnumerable<T>
        where T : IComparable<T>
    {
        public class Node : IComparable<Node>
        {
            public Node _left = null;
            public Node _right = null;
            public Node _parent = null;
            public T _data;
            public int _height = 1;
            public Node(T data)
            {
                _data = data;
            }
            public int CompareTo(Node other)
            {
                return _data.CompareTo(other._data);
            }
        }
        protected Node _root = null;
        protected Node _current = null;
        
        private int _count = 0;

        public int _Count { get { return _count; } }

        #region Base Functionality (Add, Contains, ToArray, IsEmpty, Count, Remove)
        public virtual void Add(T data) 
        {
           addData(data);
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
        public virtual T Remove(T value)
        {
            Node current = find(value);
            if (current == null)
                throw new Exception("Value not found");

            Node parent = current._parent;
            int child = hadChild(current);
            bool lor = leftOrRight(value, parent);

            if (child == 0)
            {
                if (lor == true)
                    parent._right = null;
                else
                    parent._left = null;
            }
            else if (child == 1)
            {
                if (lor == true)
                {
                    if (lor == true)
                        parent._right = current._right;
                    else
                        parent._left = current._right;
                }
                else
                {
                    if (parent._right == current)
                        parent._right = current._left;
                    else
                        parent._left = current._left;
                }
            }
            else
            {
                Node curRL = current._right._left;
                if (curRL == null)
                {
                    parent._right = current._right;
                    parent._right._left = current._left;
                }
                else
                {
                    Node curRLParent = current._right;
                    while (curRL._left != null)
                    {
                        curRLParent = curRL;
                        curRL = curRL._left;
                    }
                    curRLParent._left = curRL._right;
                    curRL._left = current._left;
                    curRL._right = current._right;
                    if (parent == null)
                        _root = curRL;
                    else
                    {
                        int result = parent.CompareTo(current);
                        if (result > 0)
                            parent._left = curRL;
                        else if (result < 0)
                            parent._right = curRL;
                    }
                }
            }
            _count--;
            return current._data;
        }
        public T[] ToArray()
        {
            T[] arr = new T[_count];
            toArray(_root, arr, 0);
            return arr;
        }
        public int Count() => _count;
        public bool IsEmpty(IBinarySearchTree<T> tree) => _root == null;
        #endregion

        #region private Functionality (find, toArray, hadChild, leftOrRight)
        private int hadChild(Node node)
        {
            if (node._left == null && node._right == null)
                return 0;
            else if (node._left != null && node._right != null)
                return 2;
            else
                return 1;
        }
        protected Node find(T value)
        {
            Node parent;
            Node current = _root;
            parent = null;
            while (current != null)
            {
                int result = current._data.CompareTo(value);
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
            return current;
        }
        private int toArray(Node node, T[] arr, int count = 0)
        {
            if (node == null)
                return count;
            count = toArray(node._left, arr, count);
            arr[count++] = node._data;
            count = toArray(node._right, arr, count);
            return count;
        }
        private bool leftOrRight(T value, Node node) => node._left._data.CompareTo(value) == 0;
        protected void swap(Node firstNode, Node secondNote)
        {
            Node leftFirst = firstNode._left;
            Node leftSecond = secondNote._left;
            Node right1 = firstNode._right;
            Node right2 = secondNote._right;
            Node parent1 = firstNode._parent;
            Node parent2 = secondNote._parent;
            firstNode._left = leftSecond;
            secondNote._left = leftFirst;
            firstNode._right = right2;
            secondNote._right = right1;
            firstNode._parent = parent2;
            secondNote._parent = parent1;
        }
        protected Node addData(T data)
        {
            Node newNode = new Node(data);
            Node trPar = null;

            if (_root == null)
            {
                _root = newNode;
                _count++;
                return newNode;
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
                           // newNode._height = 1;
                            return newNode;
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
                          //  newNode._height = 1;
                            return newNode;
                        }
                    }
                }
            }
        }
        #endregion

        #region PreOrder, InOrder, PostOrder Write Recursive
        public void TestInOrderPrint() => testPrintInOrder(_root);
        public void PreOrderPrint() => printPreOrder(_root);
        public void InOrderPrint() => printInOrder(_root);
        public void PostOrderPrint() => printPostOrder(_root);

        #region Private Part
        private void testPrintInOrder(Node node)
        {
            if (node == null)
                return;
            printInOrder(node._left);
            Console.Write(node._data + " " + node._height + "  ");
            printInOrder(node._right);
        }
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
        //public IEnumerable<T> EnumerateNodes()
        //{
        //    yield return _root._data;
        //    if ( _root._left!= null)
        //        foreach (T child in _root._left.EnumerateNodes())
        //            yield return child;
        //    if (_root._right != null)
        //        foreach (T child in _root._right.EnumerateNodes())
        //            yield return child;
        //}
        //if (node == null)
        //    yield break;
        //GetEnumerator(node._left);
        //yield return node._data;
        //GetEnumerator(node._right);
        //if (node == null)
        //    yield break;
        // yield return GetEnumerator(node._left);
        //yield return node._data;
        //yield return GetEnumerator(node._right);
        //throw new Exception();
    }
    //public IEnumerator<T> GetEnumerator() => GetEnumerator(_root);
    //IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
    #endregion
}
