using System;
using System.Collections;
using System.Collections.Generic;

namespace InOne.Task.Structure.IMPL
{
    public class LinkedStack<T> : IStack<T>, IEnumerable<T>
    {
        private MyLinkedList<T> _list;
        public LinkedStack()
        {
            _list = new MyLinkedList<T>();
        }

        public bool IsEmpty() => IsEmpty();
        public T Peek() => !_list.IsEmpty() ? _list.Last() : throw new Exception("LinkedStack is empty");
        public T Pop()
        {
            if (!_list.IsEmpty())
            {
                T tr = _list.Last();
                _list.RemoveLast();
                return tr;
            }
            throw new Exception("LinkedStack is Empty");
        }
        public void Push(T data)
        {
            if (_list != null)
                _list.Add(data);
            else
                _list.AddFirst(data);
        }
        public void Reverse() => _list.Reverse();
        public int Count() => _list.Count();

        #region IEnumerator IMPL
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this._list)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
        #endregion
    }
}
