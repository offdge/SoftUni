using System;
using System.Linq;

namespace Problem_03_2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var numberOfSquares = 0;
            var matrixRow = matrixSize[0];
            var matrixCol = matrixSize[1];
            var matrix = new string[matrixRow, matrixCol];
 
            for (int row = 0; row < matrixRow; row++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrixCol; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < matrixRow - 1; row++)
            {
                for (int col = 0; col < matrixCol - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row +1, col] && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        numberOfSquares++;
                    }
                }
            } 
            Console.WriteLine(numberOfSquares);
        }
    }
}