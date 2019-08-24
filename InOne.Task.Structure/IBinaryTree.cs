using System;

namespace InOne.Task.Structure
{
    public interface IBinaryTree<T>
        where T : IComparable<T>
    {
        int Count();
        bool IsEmpty(IBinaryTree<T> tree);
        void Add(T value);
        T Remove(T value);
        bool Contains(T value);
        void PreOrderPrint(T node);
        void InOrderPrint(T node);
        void PostOrderPrint(T node);
        T[] ToArray(IBinaryTree<T> tree);
    }
}
