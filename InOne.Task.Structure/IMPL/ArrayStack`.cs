using System;

namespace InOne.Task.Structure.IMPL
{
    class ArrayStack<T> : IStack<T>
    {
        private T[] _arr;
        private int _top;
        private int _size;
        public ArrayStack(int size)
        {
            _size = size;
            _arr = new T[_size];
            _top = -1;
        }
        public int Count() => _arr.Length;
        public bool IsEmpty() => _arr.Length == 0;
        public T Peek() => _arr[0];
        public T Pop() => _arr[_top--];
        public void Push(T data)
        {
            if (_top != (_size - 1))
                _arr[++_top] = data;
            else
                throw new IndexOutOfRangeException();
        }
        public void Reverse()
        {
            throw new System.NotImplementedException();
        }
    }
}
