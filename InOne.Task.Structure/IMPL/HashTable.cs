using System;
using System.Collections;
using InOne.Task.Additions;

namespace InOne.Task.Structure.IMPL
{
    public class HashTable : IHashTable, IEnumerable
    {
        public class Node : IComparable<Node>
        {
            public string Key { get; set; }
            public Person Value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public int CompareTo(Node other) => Value.CompareTo(other.Value);
        }

        private Node[] uni;
        private readonly int tableSize;

        public HashTable(int maxTableSize)
        {
            tableSize = maxTableSize;
            uni = new Node[tableSize];
        }


        #region Base Functionality
        public void Add(Person p) => add(p.BirthDay.ToString(), p);
        public Person GetPerson(DateTime dt)
        {
            string key = dt.ToString();
            int genIndex = HashFunction(key);
            Node node = uni[genIndex];
            while (node != null)
            {
                if (node.Key == key) 
                    return node.Value;
                node = node.Next;
            }

            throw new Exception("Don't have the key in hash!");
        }
        public Person Remove(Person p)
        {
            throw new NotImplementedException();
        }
        public Person[] GetPeople(DateTime dt)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region private Functionality

        private int HashFunction(string key)
        {
            int index = 7;
            int asciiVal = 0;
            for (int i = 0; i < key.Length; i++)
            {
                asciiVal = (int)key[i] * i;
                index = index * 31 + asciiVal;
            }
            return index % tableSize;
        }

        private void CompressionFunction()
        {

        }
        private void add(string key, Person value)
        {
            int genIndex = HashFunction(key);
            Node node = uni[genIndex];

            if (node == null)
            {
                uni[genIndex] = new Node() { Key = key, Value = value };
                return;
            }

            if (node.Key == key)
                throw new Exception("Can't use same key!");

            while (node.Next != null)
            {
                node = node.Next;
                if (node.Key == key)
                    throw new Exception("Can't use same key!");
            }

            Node newNode = new Node() { Key = key, Value = value, Previous = node, Next = null };
            node.Next = newNode;
        }
        #endregion

        #region Enumerator IMPL
        public IEnumerator GetEnumerator()
        {
            foreach (var item in uni)
            {
                yield return item.Value.FullName;
            }
        }


        #endregion
    }
}
