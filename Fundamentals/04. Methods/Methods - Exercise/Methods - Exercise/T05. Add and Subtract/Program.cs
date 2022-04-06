using System;

namespace T05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sumOfNum = SumOfFirstAndSecondNum(firstNum, secondNum);
            int subOfSum = SubSumAndThirdNum(thirdNum);
            Console.WriteLine(sumOfNum-subOfSum);
        }

      
        static int SumOfFirstAndSecondNum(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }

        static int SubSumAndThirdNum(int thirdNum)
        {
            int sum = 0;
            sum -= thirdNum;
            return sum;
        }
    }
}
