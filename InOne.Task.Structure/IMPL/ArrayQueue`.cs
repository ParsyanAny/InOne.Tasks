using System;
using System.Collections;
using System.Collections.Generic;

namespace InOne.Task.Structure.IMPL
{
    public class ArrayQueue<T> : IQueue<T>, IEnumerable<T>
    {
        private T[] _arr;
        private int enq = -1;
        private int deq = -1;
        private int _size;

        public ArrayQueue(int size)
        {
            _size = size;
            _arr = new T[_size];
            enq = -1;
        }

        public T Dequeue()
        {
            if (deq + 1 != _size)
                deq++;
            else
                deq = 0;
            var tr = _arr[deq];
            _arr[deq] = default;
            return tr;
        }
        public T Peek() => _arr[0];
        public void Enqueue(T data)
        {
            //if (deq != 0 && enq != 0 && deq != enq)
            //    throw new Exception();
            if (enq + 1 != _size)
                enq++;
            else
                enq = 0;
            _arr[enq] = data;
        }
        public bool IsEmpty() => _arr.Length == 0;
        public int Count() => _arr.Length;
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
