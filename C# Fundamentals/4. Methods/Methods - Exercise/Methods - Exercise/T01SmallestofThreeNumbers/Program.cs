using System;

namespace T01SmallestofThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            Console.WriteLine(PrintSmallerN(firstNum,secondNum,thirdNum));
        }

        static double PrintSmallerN(double firstNum, double secondNum, double thirdNum)
        {
            double smallest = 0;
            if (firstNum > thirdNum && secondNum>thirdNum)
            {
                smallest = thirdNum;
            }
            else if (firstNum > secondNum && secondNum < thirdNum)
            {
                smallest = secondNum;
            }
            else if (secondNum>firstNum && thirdNum>firstNum)
            {
                smallest = firstNum;
            }
            else if (firstNum==secondNum && firstNum==thirdNum)
            {
                smallest = firstNum;
            }
         

            return smallest;
        }
    }
}
