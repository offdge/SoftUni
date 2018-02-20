using System;
using System.Linq;

namespace Problem_02_Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine().Trim());
            var matrix = new int [n,n];
            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix [i,j] = input[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                primaryDiagonalSum += matrix[i,i];
                secondaryDiagonalSum += matrix[i,n-1-i];
            }
            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}