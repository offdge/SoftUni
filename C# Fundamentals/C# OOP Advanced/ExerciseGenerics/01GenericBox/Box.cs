using System;
using System.Collections;
using System.Collections.Generic;


namespace _01GenericBox
{
    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{this.value.GetType().FullName}: {value}";
        }
    }
}