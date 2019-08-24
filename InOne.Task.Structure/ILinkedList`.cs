using InOne.Task.Structure.IMPL;
using System;
using System.Collections.Generic;
using System.Text;

namespace InOne.Task.Structure
{
    public interface ILinkedList<T>
    {
        void Add(T data);
        void AddFirst(T data);
        void AddLast(T data);
        void RemoveFirst();
        int Count();
        bool IsEmpty();
        T First();
        void Reverse();
        MyLinkedList<T> ReverseList();
        void InsertById(int index, T data);
        void RemoveById(int index);
    }
}
