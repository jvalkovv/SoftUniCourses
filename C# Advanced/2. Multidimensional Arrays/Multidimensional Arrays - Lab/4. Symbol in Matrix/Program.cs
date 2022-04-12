using System;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colEl = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colEl[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool isSymbol = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    if (matrix[i, l] == symbol)
                    {
                        Console.WriteLine($"({i}, {l})");
                        isSymbol = true;
                        return;
                    }
                }
            }
            if (!isSymbol)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
