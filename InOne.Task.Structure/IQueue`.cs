using System;
using System.Collections.Generic;
using System.Text;

namespace InOne.Task.Structure
{
    public interface IQueue<T>
    {
        void Enqueue(T data); // Adds an element to the queue
        T Dequeue(); // Removes first inserted element
        int Count();
        bool IsEmpty();
        T Peek(); // Gets element on top
        void Reverse();
    }
}
