using System;
using System.Linq;

namespace Problem_1.Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrixRow = input[0];
            var matrixCol = input[1];

            string[,] matrix = new string[matrixRow,matrixCol];

            for (int row = 0; row < matrixRow; row++)
            {
                for (int col = 0; col < matrixCol; col++)
                {
                    matrix[row,col] = ("" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row));
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}