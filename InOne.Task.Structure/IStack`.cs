using System;
using System.Collections.Generic;
using System.Text;

namespace InOne.Task.Structure
{
    public interface IStack<T>
    {
        T Pop(); // Removes top element
        void Push(T data); // Adds an element on top
        T Peek(); // Gets element on top
        void Reverse();
        int Count();
        bool IsEmpty();
    }
}
