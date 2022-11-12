using System;
using System.Linq;

namespace _1.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int primaryDiagonalSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        primaryDiagonalSum += matrix[row, col];
                    }
                }
            }

            int secondaryDiagonalSum = 0;
            int start = n - 1;

            for (int i = 0; i < n; i++)
            {
                secondaryDiagonalSum += matrix[i, start];
                start--;
            }

            int result = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(result);
        }
    }
}
