using System;

namespace InOne.Task.Structure
{
    public interface IBinarySearchTree<T>
        where T : IComparable<T>
    {
        void Add(T value);
        T Remove(T value);
        bool Contains(T value);
        T[] ToArray();
        int Count();
        bool IsEmpty(IBinarySearchTree<T> tree);

        void PreOrderPrint();
        void InOrderPrint();
        void PostOrderPrint();
    }
}
