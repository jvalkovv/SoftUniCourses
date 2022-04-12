using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = ReadMatrix(size[0], size[1]);
            int maxRows = 0;
            int maxCols = 0;
            int maxSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col]
                        + matrix[row + 1, col]
                        + matrix[row, col + 1]
                        + matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRows = row;
                        maxCols = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxRows, maxCols]} {matrix[maxRows, maxCols+1]}");
            Console.WriteLine($"{matrix[maxRows+1, maxCols]} {matrix[maxRows+1, maxCols+1]}");
            Console.WriteLine(maxSum);
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }

    }
}
