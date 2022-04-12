using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = ReadMatrix(rows);
            string cmd;

            while ((cmd = Console.ReadLine()) != "END")
            {
                var splitted = cmd.Split(' ');
                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);
                bool isInvalid = false;
                if (matrix.Length <= row || row < 0)
                {
                    isInvalid = true;
                }
                else if (matrix[row].Length <= col || col < 0)
                {
                    isInvalid = true;
                }
                if (isInvalid)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (splitted[0] == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    if (splitted[0] == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
            }
            foreach (var item in matrix)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
        static int[][] ReadMatrix(int rows)
        {
            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(" ").Select(int.Parse).ToArray();

                matrix[row] = new int[rowData.Length];
                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }
            return matrix;
        }
    }
}
