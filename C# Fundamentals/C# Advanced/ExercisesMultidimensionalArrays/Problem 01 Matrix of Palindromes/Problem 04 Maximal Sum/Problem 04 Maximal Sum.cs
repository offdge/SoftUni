using System;
using System.Linq;

namespace Problem_04_Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrixRow = matrixSize[0];
            var matrixCol = matrixSize[1];
            var matrix = new int[matrixRow, matrixCol];
            var maxMatrix = new int[3,3];
            var maxSum = 0;

            for (int row = 0; row < matrixRow; row++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrixCol; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < matrixRow - 2; row++)
            {
                for (int col = 0; col < matrixCol - 2; col++)
                {
                    var sum = matrix[row,     col] + matrix[row,     col + 1] + matrix[row,     col + 2] 
                            + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] 
                            + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        maxMatrix = new int[,] {{ matrix[row,     col] , matrix[row,     col + 1] , matrix[row,     col + 2] },
                                                { matrix[row + 1, col] , matrix[row + 1, col + 1] , matrix[row + 1, col + 2] },
                                                { matrix[row + 2, col] , matrix[row + 2, col + 1] , matrix[row + 2, col + 2] } };
                    }
                }
            }

            Console.WriteLine("Sum = " + maxSum);

            for (int row = 0; row < maxMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < maxMatrix.GetLength(1); col++)
                {
                    Console.Write(maxMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
