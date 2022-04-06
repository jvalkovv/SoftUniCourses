using System;
using System.Linq;
namespace T03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int number = int.Parse(Console.ReadLine());
            int[] arr1 = new int[number];
            int[] arr2 = new int[number];

            for (int row = 1; row <= number; row++)
            {
                int [] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstNumber = currentRow[0];
                int secondNumber = currentRow[1];

                if (row %2 != 0)
                {
                    arr1[row - 1] = firstNumber;
                    arr2[row - 1] = secondNumber;
                }
                else
                {
                    arr1[row - 1] = secondNumber;
                    arr2[row - 1] = firstNumber;
                }  

            }
            Console.WriteLine(String.Join(" ",arr1));
            Console.WriteLine(String.Join(" ", arr2));

        }
    }
}
