using System;
using System.Collections;
using System.Collections.Generic;

namespace _01GenericBox
{
    public class Box<T> : IEnumerable
    {
        private List<T> box;

        public T Value { get; private set; }

        public Box()
        {
            this.box = new List<T>();

        }
        public Box(T value)
        {
            this.Value = value;
        }

        public void Add(T value)
        {
            this.box.Add(value);
        }

        public IEnumerator GetEnumerator()
        {
            return this.box.GetEnumerator();
        }

        public void Print()
        {
            foreach (var item in box)
            {
                Console.WriteLine($"{item.GetType().FullName}: {item}");
            }
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var temp = box[firstIndex];
            box[firstIndex] = box[secondIndex];
            box[secondIndex] = temp;
        }
    }
}