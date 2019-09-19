using System;

namespace InOne.Task.Additions
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDay { get; set; }

        public string FullName => $"{Name} {SurName}";

        public int CompareTo(Person other) => this.BirthDay.CompareTo(other.BirthDay);
    }
}
