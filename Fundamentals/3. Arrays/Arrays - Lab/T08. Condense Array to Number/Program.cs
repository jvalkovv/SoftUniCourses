using System;
using System.Linq;
namespace T08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int firstLength = array.Length;

            for (int i = 0; i < firstLength - 1; i++)
            {
                int[] condensed = new int[array.Length - 1];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    condensed[j] = array[j] + array[j + 1];
                }
                array = condensed;
            }
            Console.WriteLine(array[0]);
        }
    }
}
