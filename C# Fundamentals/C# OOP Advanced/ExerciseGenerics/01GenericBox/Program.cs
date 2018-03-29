using System;
using System.Collections.Generic;

namespace _01GenericBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<int>();

            box.Add(1234);


            Console.WriteLine(box.ToString());
        }
    }
}
