using InOne.Task.Structure.IMPL;
using System;
using System.Collections.Generic;
using System.Text;

namespace InOne.Task.Structure
{
    public interface IBinaryTree<T>
    {
        bool IsEmpty(BinaryTree<T> tree);
        void Add(T value);
        T Remove(T value);
        bool Contains(T value);
        void PreOrderPrint(T node);
        void InOrderPrint(T node);
        void PostOrderPrint(T node);
        T[] ToArray(BinaryTree<T> tree);
    }
}
