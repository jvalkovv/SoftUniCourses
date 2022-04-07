using System;
using System.Linq;

namespace T04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int rotation = int.Parse(Console.ReadLine());
            
            for (int rot = 0; rot < rotation; rot++)
            {
                int firstEl = arr[0];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = firstEl;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
