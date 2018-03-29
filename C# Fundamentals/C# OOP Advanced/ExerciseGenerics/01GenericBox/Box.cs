using System;
using System.Collections.Generic;

namespace _01GenericBox
{
    public class Box<T>
    {
        private List<T> box;

        public T Value { get; set; }

        public Box()
        {
            this.box = new List<T>();
        }

        public void Add(T item)
        {
            this.box.Add(item);
            this.Value = item;
        }

        public override string ToString()
        {
            return $"{typeof(T).FullName}: {this.Value}";
        }
    }
}
