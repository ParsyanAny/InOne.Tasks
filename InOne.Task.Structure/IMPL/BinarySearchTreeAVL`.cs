using System;

namespace InOne.Task.Structure.IMPL
{
    public class BinarySearchTreeAVL<T> : BinarySearchTree<T>, IBinarySearchTreeAVL<T>
        where T : IComparable<T>
    {
        public override void Add(T data)
        {
            base.Add(data);
            update(find(data));
        }
        public override T Remove(T value) => remove(value);

        #region private Functionality (getHeight, isBalanced)
        private T remove(T value)
        {
            Node removeNode = find(value);
            base.Remove(value);
            update(find(value));
            return removeNode.Data;
        }
        int getBalance(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            int leftH = node.Left != null ? node.Left.Height : 1;
            int rightH = node.Right != null ? node.Right.Height : 1;
            int balance;

            balance = leftH - rightH;

            return balance;
        }
        private void update(Node current)
        {
            Node cur = current;
            Node parent = current.Parent;
            while (current != null)
            {
                int parH = current.Parent != null ? current.Parent.Height : 1;
                int curLH = current.Left != null ? current.Left.Height : 1;
                int curRH = current.Right != null ? current.Right.Height : 1;

                if (current.Height - curLH >= 2 || current.Height - curRH >= 2)
                {
                    balanced(cur);
                    return;
                }
                else if (current.Parent != null && current.Parent.Height - current.Height == 1)
                    return;
                else
                {
                    if (current.Parent != null)
                        current.Parent.Height = current.Height + 1;
                    current = current.Parent;
                }
            }
        }
        public bool balanced(Node current)
        {
            int balance = getBalance(current.Parent.Parent);

            if (balance > 0)
            {
                if (getBalance(current.Left) > 0)
                    current = rotateLL(current.Parent);
                else
                    current = rotateLR(current.Parent);
            }
            else if (balance < 0)
            {
                if (getBalance(current.Right) > 0)
                    current = rotateRL(current.Parent);
                else
                    current = rotateRR(current.Parent);
            }
            return true;
        }
        private Node rotateRR(Node parent)
        {
            Node parpar = parent?.Parent;
            parent.Parent = parpar?.Parent;
            parent.Left = parpar;
            parpar.Right = null;
            if (parpar.Parent == null)
                _root = parent;
            else
                parpar.Parent.Right = parent;
            parent.Left.Height = parent.Height - 1;
            //parent.Right.Height = parent.Height - 1;
            return parent;

        }
        private Node rotateLL(Node parent)
        {
            Node parpar = parent.Parent;
            parent.Parent = parpar?.Parent;
            parent.Right = parpar;
            parpar.Left = null;
            
            parent.Left.Height = parent.Height - 1;
            parent.Right.Height = parent.Height - 1;
            if (parpar.Parent == null)
                _root = parent;
            else
                parpar.Parent.Left = parent;
            //update(parent);
            return parent;
        }
        private Node rotateLR(Node parent)
        {
            Node current = parent.Left;
            parent.Left = rotateRR(current);
            return rotateLL(parent);
        }
        private Node rotateRL(Node parent)
        {
            Node current = parent.Right;
            parent.Right = rotateLL(current);
            return rotateRR(parent);
        }
        #endregion
    }
}
