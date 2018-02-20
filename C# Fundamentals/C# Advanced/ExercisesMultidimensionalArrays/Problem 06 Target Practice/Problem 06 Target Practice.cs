using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_06_Target_Practice
{
    class Program
    {
        static void Main()
        {
            var matrixSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var snake = Console.ReadLine().Trim().ToArray(); ;
            var shotparameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var impactRow = shotparameters[0];
            var impactColumn = shotparameters[1];
            var radius = shotparameters[2];
            var rows = matrixSize[0];
            var columns = matrixSize[1];
            var matrix = new char[rows, columns];
            var matrixFinal = new char[rows, columns];
            var check = true;
            var counter = 0;
            ///////////Matrix fill
            for (int row = rows - 1; row >= 0; row--)
            {
                if (check == true)
                {
                    for (int col = columns - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[counter++ % snake.Length];
                    }
                    check = false;
                }
                else
                {
                    for (int col = 0; col < columns; col++)
                    {
                        matrix[row, col] = snake[counter++ % snake.Length];
                    }
                    check = true;
                }
            }
            ///////////Impact Zone
            if (impactRow < rows && impactColumn < columns)
            {
                for (int i = 0; i <= radius; i++)
                {
                    for (int j = 0; j <= radius - i; j++)
                    {
                        if (impactRow - i >= 0)
                        {
                            if (impactColumn + j < columns)
                            {
                                matrix[impactRow - i, impactColumn + j] = ' ';
                            }
                            if (impactColumn - j >= 0)
                            {
                                matrix[impactRow - i, impactColumn - j] = ' ';
                            }
                        }
                        if (impactRow + i < rows)
                        {
                            if (impactColumn + j < columns)
                            {
                                matrix[impactRow + i, impactColumn + j] = ' ';
                            }
                            if (impactColumn - j >= 0)
                            {
                                matrix[impactRow + i, impactColumn - j] = ' ';
                            }
                        }
                    }
                }
            }
            ///////////MatrixFinal fill
            for (int column = 0; column < columns; column++)
            {
                var fill = new List<char>();
                for (int row = rows - 1; row >= 0; row--)
                {
                    if (matrix[row, column] != ' ')
                    {
                        fill.Add(matrix[row, column]);
                    }
                }
                for (int i = 0; i < rows; i++)
                {
                    if (i < fill.Count)
                    {
                        matrixFinal[rows - 1 - i, column] = fill[i];
                    }
                    else
                    {
                        matrixFinal[rows - 1 - i, column] = ' ';
                    }
                }
            }
            ////////////Result
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write(matrixFinal[row, col] + "");
                }
                Console.WriteLine();
            }
        }
    }
}