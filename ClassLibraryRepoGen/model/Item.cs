using System;
using System.Collections.Generic;

namespace ClassLibraryRepoGen.model
{
    public abstract class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        protected Item(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        protected bool Equals(Item other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Item) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public static bool operator ==(Item left, Item right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Item left, Item right)
        {
            return !Equals(left, right);
        }

        private sealed class NameRelationalComparer : Comparer<Item>
        {
            public override int Compare(Item x, Item y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (ReferenceEquals(null, y)) return 1;
                if (ReferenceEquals(null, x)) return -1;
                return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
            }
        }

        public static Comparer<Item> NameComparer { get; } = new NameRelationalComparer();

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
        }
    }



}