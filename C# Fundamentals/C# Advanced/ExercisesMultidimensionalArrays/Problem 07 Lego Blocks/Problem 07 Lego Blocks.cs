using System;
using System.Linq;

namespace Problem_07_Lego_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstJaggedArray    = new int[n][];
            var secondJaggedArray   = new int[n][];
            var check = true;
            for (int j = 0; j < n; j++)
            {
                firstJaggedArray[j]     = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            for (int k = 0; k < n; k++)
            {
                secondJaggedArray[k]    = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            for (int i = 0; i < n; i++)
            {
                var count = firstJaggedArray[0].Length + secondJaggedArray[0].Length;

                if (firstJaggedArray[i].Length + secondJaggedArray[i].Length != count)
                {
                    var totalCells = 0;
                    for (int l = 0; l < n; l++)
                    {
                        totalCells += firstJaggedArray[l].Length + secondJaggedArray[l].Length;
                    }
                    Console.WriteLine("The total number of cells is: {0}", totalCells);
                    check = false;
                }
            }
            if (check == true)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("[" + string.Join(", ", firstJaggedArray[i]) + ", " + string.Join(", ", secondJaggedArray[i].Reverse()) + "]");
                }
            }
        }
    }
}