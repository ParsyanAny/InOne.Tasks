using System;
using System.Collections;
using System.Collections.Generic;

namespace InOne.Task.Structure.IMPL
{
    public class BinarySearchTree<T> : IBinarySearchTree<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        public class Node : IComparable<Node>
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node Parent { get; set; }
            private T _data;
            public T Data { get { return _data; } }
            public int Height = 1;
            public Node(T data) { _data = data; }
            public int CompareTo(Node other) => Data.CompareTo(other.Data);
            protected void swap(Node firstNode, Node secondNote)
            {
                Node leftFirst = firstNode.Left;
                Node leftSecond = secondNote.Left;
                Node right1 = firstNode.Right;
                Node right2 = secondNote.Right;
                Node parent1 = firstNode.Parent;
                Node parent2 = secondNote.Parent;
                firstNode.Left = leftSecond;
                secondNote.Left = leftFirst;
                firstNode.Right = right2;
                secondNote.Right = right1;
                firstNode.Parent = parent2;
                secondNote.Parent = parent1;
            }
        }
        protected Node _root = null;
        private int _count = 0;
        public int _Count { get { return _count; } }

        #region Base Functionality (Add, Contains, ToArray, IsEmpty, Count, Remove)
        public virtual void Add(T data) => addData(data);
        public bool Contains(T value)
        {
            var current = _root;
            Node parent = null;

            while (current != null)
            {
                var result = current.Data.CompareTo(value);
                if (result > 0)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.Right;
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

            Node parent = current.Parent;
            int child = hadChild(current);
            bool lor = current.Left.Data.CompareTo(value) == 0;

            if (child == 0)
            {
                if (lor == true)
                    parent.Right = null;
                else
                    parent.Left = null;
            }
            else if (child == 1)
            {
                if (lor == true)
                {
                    if (lor == true)
                        parent.Right = current.Right;
                    else
                        parent.Left = current.Right;
                }
                else
                {
                    if (parent.Right == current)
                        parent.Right = current.Left;
                    else
                        parent.Left = current.Left;
                }
            }
            else
            {
                Node curRL = current.Right.Left;
                if (curRL == null)
                {
                    parent.Right = current.Right;
                    parent.Right.Left = current.Left;
                }
                else
                {
                    Node curRLParent = current.Right;
                    while (curRL.Left != null)
                    {
                        curRLParent = curRL;
                        curRL = curRL.Left;
                    }
                    curRLParent.Left = curRL.Right;
                    curRL.Left = current.Left;
                    curRL.Right = current.Right;
                    if (parent == null)
                        _root = curRL;
                    else
                    {
                        int result = parent.CompareTo(current);
                        if (result > 0)
                            parent.Left = curRL;
                        else if (result < 0)
                            parent.Right = curRL;
                    }
                }
            }
            _count--;
            return current.Data;
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
            if (node.Left == null && node.Right == null)
                return 0;
            else if (node.Left != null && node.Right != null)
                return 2;
            else
                return 1;
        }
        protected Node find(T value)
        {
            Node current = _root;
            while (current != null)
            {
                int result = current.Data.CompareTo(value);
                if (result > 0)
                {
                    current = current.Left;
                }
                else if (result < 0)
                {
                    current = current.Right;
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
            count = toArray(node.Left, arr, count);
            arr[count++] = node.Data;
            count = toArray(node.Right, arr, count);
            return count;
        }
        protected Node addData(T data)
        {
            Node newNode = new Node(data);
            Node trPar = null;
            Node _current;
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
                    if (data.CompareTo(_current.Data) == -1)
                    {
                        _current = _current.Left;
                        if (_current == null)
                        {
                            trPar.Left = newNode;
                            newNode.Parent = trPar;
                            _count++;
                            return newNode;
                        }
                    }
                    else
                    {
                        _current = _current.Right;
                        if (_current == null)
                        {
                            trPar.Right = newNode;
                            newNode.Parent = trPar;
                            _count++;
                            return newNode;
                        }
                    }
                }
            }
        }
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
            printInOrder(node.Left);
            Console.Write(node.Data + " ");
            printInOrder(node.Right);
        }
        private void printPostOrder(Node node)
        {
            if (node == null)
                return;
            printInOrder(node.Left);
            printInOrder(node.Right);
            Console.Write(node.Data + " ");
        }
        private void printPreOrder(Node node)
        {
            if (node == null)
                return;
            Console.Write(node.Data + " ");
            printInOrder(node.Left);
            printInOrder(node.Right);
        }
        #endregion
        #endregion

        #region IEnumerable IMPL
        public IEnumerator<T> GetEnumerator()
        {
            T[] arr = ToArray();
            foreach (var item in arr)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
    }
    #endregion
}
