using System;
using System.Linq;
namespace T06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                for (int k = 0; k < i; k++)
                {
                    leftSum +=arr[k];
                }
                
                int rightSum = 0;
                for (int j = arr.Length-1; j > i; j--)
                {
                    rightSum += arr[j];
                }

                if (leftSum==rightSum && !isFound)
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
