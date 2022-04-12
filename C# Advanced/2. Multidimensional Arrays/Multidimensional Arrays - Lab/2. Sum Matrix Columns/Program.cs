using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[sizeOfMatrix[0], sizeOfMatrix[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var col = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = col[cols];
                }
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
