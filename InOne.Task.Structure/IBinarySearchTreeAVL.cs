using System;

namespace InOne.Task.Structure
{
    public interface IBinarySearchTreeAVL<T>
        where T : IComparable<T>
    {
        bool Contains(T value);
        void Add(T value);
        T Remove(T value);
    }
}
