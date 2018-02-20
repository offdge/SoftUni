using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_05_Rubik_s_Matrix
{
    class Program
    {
        static void Main()
        {
            var matrixSize  = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var commands    = int.Parse(Console.ReadLine());
            var matrix      = new int[matrixSize[0], matrixSize[1]];
            var checkMatrix = new int[matrixSize[0], matrixSize[1]];

            Fill(matrix, checkMatrix, matrixSize[0], matrixSize[1]);

            for (int num = 0; num < commands; num++)
            {
                var input = Console.ReadLine().Split().ToArray();
                Rearrange(matrix, checkMatrix, input);
            }
            Swap(matrix, checkMatrix);
        }
        static void Fill (int[,]matrix, int[,] checkMatrix, int rows, int columns)
        {
            var count = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = ++count;
                    checkMatrix[row, col] = count;
                }
            }
        }
        static void Rearrange (int[,] matrix, int[,] checkMatrix, string[] input)
        {
            var oldOrder = new List<int>();
            var newOrder = new List<int>();
            var position = int.Parse(input[0]);
            var direction = input[1];
            var moves = int.Parse(input[2]);

            if (direction == "up" || direction == "down")
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    oldOrder.Add(matrix[i, position]);
                }
            }
            if (direction == "left" || direction == "right")
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    oldOrder.Add(matrix[position, i]);
                }
            }

            moves = int.Parse(input[2]) % oldOrder.Count;

            if (direction == "down" || direction == "right")
            {
                newOrder = oldOrder.Skip(oldOrder.Count - moves).ToList();
                newOrder.AddRange(oldOrder.Take(oldOrder.Count - moves));
            }
            if (direction == "up" || direction == "left")
            {
                newOrder = oldOrder.Skip(moves).ToList();
                newOrder.AddRange(oldOrder.Take(moves));
            }
            if (direction == "up" || direction == "down")
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, position] = newOrder[i];
                }
            }
            if (direction == "left" || direction == "right")
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[position, i] = newOrder[i];
                }
            }
        }
        static void Swap (int[,] matrix, int[,] checkMatrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] != checkMatrix[row, col])
                    {
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j] == checkMatrix[row, col])
                                {
                                    Console.WriteLine("Swap ({0}, {1}) with ({2}, {3})", row, col, i, j);
                                    var temp = matrix[row, col];
                                    matrix[row, col] = checkMatrix[row, col];
                                    matrix[i, j] = temp;
                                }
                            }
                        }
                    }
                    else Console.WriteLine("No swap required");
                }
            }
        }
    }
}