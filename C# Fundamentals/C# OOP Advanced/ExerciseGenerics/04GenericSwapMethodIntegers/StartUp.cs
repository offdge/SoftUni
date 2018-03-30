using System;
using System.Collections.Generic;

namespace _01GenericBox
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var box = new Box<int>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());

                box.Add(input); 
            }

            var commandSwap = Console.ReadLine().Split();
            var firstIndex = int.Parse(commandSwap[0]);
            var secondIndex = int.Parse(commandSwap[1]);

            box.Swap(firstIndex, secondIndex);

            box.Print();
        }  
    }
}
