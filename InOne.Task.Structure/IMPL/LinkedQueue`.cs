using System;
using System.Collections;
using System.Collections.Generic;

namespace InOne.Task.Structure.IMPL
{
    public class LinkedQueue<T> : IQueue<T>, IEnumerable<T>
    {
        MyLinkedList<T> _list;
        public LinkedQueue() { _list = new MyLinkedList<T>(); }

        public int Count() => _list.Count();
        public T Dequeue()
        {
            if (!_list.IsEmpty())
            {
                T tr = _list.First();
                _list.RemoveFirst();
                return tr;
            }
            throw new Exception("LinkedQueue is Empty");
        }
        public void Enqueue(T data)
        {
            if (_list != null)
                _list.Add(data);
            else
                _list.AddFirst(data);
        }
        public T Peek() => !_list.IsEmpty() ? _list.First() : throw new Exception("LinkedQueue is empty");
        public bool IsEmpty() => _list.IsEmpty();
        public void Reverse() => _list.Reverse();

        #region IEnumerator IMPL
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _list)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
        #endregion
    }
}
