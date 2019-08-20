using System.Collections;
using System.Collections.Generic;

namespace InOne.Task.Structure.IMPL
{
    public class MyLinkedList<T> : IEnumerable<T>, ILinkedList<T>
    {
        private Item<T> _head = null;
        private Item<T> _tail = null;
        private int _count = 0;
        public int _Count { get => _count; }

        #region Base Functionality
        public void Add(T data)
        {
            Item<T> item = new Item<T>(data);
            if (_head == null)
            {
                _head = item;
            }
            else
            {
                _tail.Next = item;
            }
            _tail = item;
            _count++;
        }
        public void AddFirst(T data)
        {
            Item<T> item = new Item<T>(data);

            if (_tail == null && _head == null)
            {
                _head = item;
                _tail = item;
            }
            else
            {
                item.Next = _head;
                _head = item;
            }
            _count++;
        }
        public void AddLast(T data)
        {
            Item<T> item = new Item<T>(data);
            if (_head == null)
            {
                _head = _tail = item;
                _head.Next = _tail;
            }
            else
            {
                _tail.Next = item;
                _tail = item;
            }
            _count++;
        }
        public void RemoveFirst()
        {
            if (_head != null)
            {
                _head = _head.Next;
                _count--;
            }
        }
        public int Count() => _count;
        public bool IsEmpty() => _head == null;
        #endregion
        #region Extra Functionality
        public T First() => _head.Data;
        public MyLinkedList<T> Reverse()
        {
            MyLinkedList<T> revList = new MyLinkedList<T>();
            var start = _head;

            while (start != null)
            {
                revList.AddFirst(start.Data);
                start = start.Next;
            }
            return revList;
        }
        public void InsertById(int index, T data)
        {
            Item<T> item = new Item<T>(data);
            int count = 0;
            var head = _head;
            var previous = head;
            while (head.Next != null)
            {
                if (count == index)
                {
                    previous.Next = item;
                    item.Next = head;
                }
                else
                {
                    previous = head;
                    head = head.Next;
                }
                count++;
            }
            _count++;
        }
        public void RemoveById(int index)
        {
            int count = 0;
            var head = _head;
            var previous = head;
            while (count <= index)
            {
                if (count == index)
                {
                    previous.Next = head.Next;
                    head = null;
                    _count--;
                }
                else
                {
                    previous = head;
                    head = head.Next;
                }
                count++;
            }
        }
        #endregion
        #region Iterator
        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        #endregion
    }
}
