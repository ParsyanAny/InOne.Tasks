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
            update(find(data));
            //if (isBalanced() != true)
            //{
            //    Node current = find(data);
            //    Balanced();
            //}
            //Console.WriteLine(_leftHeight);
            //Console.WriteLine(_rightHeight);
        }
        public override T Remove(T value)
        {
            return base.Remove(value);
            //if (isBalanced(_root) != true)
            //{

            //}
        }
        public void update(Node current)
        {
            Node parent = current._parent;
            while (current != null && current._parent != null)
            {
                if (parent._height - current._height >= 2)
                    balanced(current._parent);
                else if (current._parent._height - current._height == 1)
                    break ;
                else
                {
                    current._parent._height = current._height + 1;
                    current = current._parent;
                }
            }
        }
        public bool balanced(Node node)
        {
            //if (fact >= 1)
            //{
            //    if (balanceFactor() > 0)
            //        node = swapLL(node);
            //    else
            //        node = swapLR(node);
            //}
            //else if (fact <= -1)
            //{
            //    if (balanceFactor() > 0)
            //        node = swapRL(node);
            //    else
            //        node = swapRR(node);
            //}
            return true;
        }
        #region private Functionality (getHeight, isBalanced)
        private Node swapRR(Node node)
        {
            //Node current = parent._right;
            //parent._right = current._left;
            //current._left = parent;
            Node nodePer = node._parent;
            node._parent = nodePer._parent;
            node._left = nodePer;
            nodePer._left = node._left;
            nodePer._right = node._right;
            //current._left = parent._parent;
            //current._parent = parent._parent;
            //current._parent._parent = parent;
            //current._left._right = null;
            return node;
        }
        private Node swapLL(Node parent)
        {
            Node current = parent._left;
            parent._left = current._right;
            current._right = parent;
            return current;
        }
        private Node swapLR(Node parent)
        {
            Node current = parent._left;
            parent._left = swapRR(current);
            return swapLL(parent);
        }
        private Node swapRL(Node parent)
        {
            Node current = parent._right;
            parent._right = swapLL(current);
            return swapRR(parent);
        }
        #endregion
    }
}
