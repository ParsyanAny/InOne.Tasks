using System;
using System.Collections;
using System.Collections.Generic;

namespace InOne.Task.Structure.IMPL
{
   public class ArrayStack<T> : IStack<T>, IEnumerable<T>
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
            int mid = (_arr.Length - 1) / 2;
            int max = _arr.Length - 1;
            for (int i = 0; i < mid; i++)
            {
                T temp = _arr[i];
                _arr[i] = _arr[max];
                _arr[max] = temp;
                max--;
            }
        }

        #region IEnumerator IMPL
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _arr)
                yield return item;
        }
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
        #endregion
    }
}
