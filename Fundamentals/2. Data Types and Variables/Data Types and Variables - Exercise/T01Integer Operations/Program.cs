using System;

namespace T01Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            long numOne = long.Parse(Console.ReadLine());
            long numTwo = long.Parse(Console.ReadLine());
            long numThree = long.Parse(Console.ReadLine());
            long numFour = long.Parse(Console.ReadLine());

            long sumOne = numOne + numTwo;

            long sumTwo = sumOne / numThree;

            long sumThree = sumTwo * numFour;

            Console.WriteLine(sumThree);
        }
    }
}
