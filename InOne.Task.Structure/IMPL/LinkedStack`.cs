using System;

namespace InOne.Task.Structure.IMPL
{
    public class LinkedStack<T> : IStack<T>
    {
        private MyLinkedList<T> _list;

        public LinkedStack()
        {
            _list = new MyLinkedList<T>();
        }
        public bool IsEmpty() => IsEmpty();
        public T Peek()
        {
            if (!_list.IsEmpty())
                return _list.First();
            return default;
        }
        public T Pop()
        {
            if (!_list.IsEmpty())
            {
                T tr = _list.First();
                _list.RemoveFirst();
                return tr;
            }
            throw new Exception("LinkedStack is Empty");
        }
        public void Push(T data)
        {
            if (_list != null)
                _list.Add(data);
            else
            {
                _list.AddFirst(data);
            }
        }
        public void Reverse() => _list.Reverse();
        public int Count() => _list.Count();
    }
}
