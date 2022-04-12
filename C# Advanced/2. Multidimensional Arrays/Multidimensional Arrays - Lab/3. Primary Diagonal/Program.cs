using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int sum = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] diagonal = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (rows == col)
                    {
                        matrix[rows, col] = diagonal[col];
                        sum += diagonal[col];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
