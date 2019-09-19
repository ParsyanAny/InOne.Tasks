using InOne.Task.Additions;
using System;

namespace InOne.Task.Structure
{
    public interface IHashTable
    {
        void Add(Person p);
        Person Remove(Person p);
        Person GetPerson(DateTime dt);
        Person[] GetPeople(DateTime dt);
    }
}
