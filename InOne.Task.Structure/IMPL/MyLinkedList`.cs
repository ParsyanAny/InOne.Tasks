using System.Collections;
using System.Collections.Generic;

namespace InOne.Task.Structure.IMPL
{
    public class MyLinkedList<T> : IEnumerable<T>, ILinkedList<T>
    {
        private class Item
        {
            public T Data { get; set; }
            public Item Next { get; set; }
            public Item(T data)
            {
                Data = data;
            }
            public override string ToString()
            {
                return Data.ToString();
            }
        }
        private Item _head = null;
        private Item _tail = null;
        private int _count = 0;
        public int _Count { get => _count; }

        #region Base Functionality
        public void Add(T data)
        {
            Item item = new Item(data);
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
            Item item = new Item(data);

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
            Item item = new Item(data);
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
        public T First() => _head.Data;
        public T Last() => _tail.Data;
        #endregion

        #region Extra Functionality
        public MyLinkedList<T> ReverseList()
        {
            var revList = new MyLinkedList<T>();
            var start = _head;
            while (start != null)
            {
                revList.AddFirst(start.Data);
                start = start.Next;
            }
            return revList;
        }
        public void Reverse()
        {
            Item prev = null;
            Item current = _head;
            Item next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            _head = prev;
        }
        public void InsertById(int index, T data)
        {
            Item item = new Item(data);
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
        public void RemoveLast()
        {
            Item current = _head;
            if (_head == null) return;
            if (_head.Next == null)
            {
                _head = null;
                return;
            }
            while (current.Next != null)
            {
                _tail = current;
                current = current.Next;
            }
            _tail.Next = null;
        }
        #endregion

        #region IEnumerator IMPL
        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
        #endregion
    }
}
