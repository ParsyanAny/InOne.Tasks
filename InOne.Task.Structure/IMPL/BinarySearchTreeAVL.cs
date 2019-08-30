using System;
using System.Collections.Generic;
using System.Text;

namespace InOne.Task.Structure.IMPL
{
    public class BinarySearchTreeAVL<T> : BinarySearchTree<T>, IBinarySearchTreeAVL<T>
        where T : IComparable<T>
    {
        public override void Add(T data)
        {
            base.Add(data);
            if (isBalanced(_root) != true)
            {

            }
        }
        public override T Remove(T value)
        {
            return base.Remove(value);
            if (isBalanced(_root) != true)
            {

            }
        }

        public bool Balanced()
        {

            return true;
        }
        #region private Functionality (getHeight, isBalanced)
        private int getHeight(Node current)
        {
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current._left);
                int r = getHeight(current._right);
                int m = l > r ? l : r;
                height = m + 1;
            }
            return height;
        }
        private bool isBalanced(Node current)
        {
            int left = getHeight(current._left);
            int right = getHeight(current._right);
            int balance = Math.Abs(left - right);
            return balance < 2;
        }
        private Node rotateRR(Node parent)
        {
            Node pivot = parent._right;
            parent._right = pivot._left;
            pivot._left = parent;
            return pivot;
        }
        private Node rotateLL(Node parent)
        {
            Node pivot = parent._left;
            parent._left = pivot._right;
            pivot._right = parent;
            return pivot;
        }
        private Node rotateLR(Node parent)
        {
            Node pivot = parent._left;
            parent._left = rotateRR(pivot);
            return rotateLL(parent);
        }
        private Node rotateRL(Node parent)
        {
            Node pivot = parent._right;
            parent._right = rotateLL(pivot);
            return rotateRR(parent);
        }
        #endregion
    }
}
