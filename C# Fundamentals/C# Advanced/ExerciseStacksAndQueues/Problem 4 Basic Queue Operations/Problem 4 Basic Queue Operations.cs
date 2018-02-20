using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            var inputNumbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            var reverseNumbers = new Queue<int>(inputNumbers);

            if (input[1] < reverseNumbers.Count)
            {
                for (int i = 0; i < input[1]; i++)
                {
                    reverseNumbers.Dequeue();
                }
                if (reverseNumbers.Contains(input[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(reverseNumbers.Min());
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}

