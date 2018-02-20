using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var reverseNumbers = new Stack<string>(input);

        while (reverseNumbers.Count != 1)
        {
            Console.Write(reverseNumbers.Pop() + " ");
        }
        Console.WriteLine(reverseNumbers.Pop());
    }
}
