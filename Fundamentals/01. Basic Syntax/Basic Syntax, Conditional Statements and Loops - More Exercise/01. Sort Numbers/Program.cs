using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.MinValue;
            int secondNumber = int.MinValue;
            int thirdNumber = int.MinValue;

            int countOfNumber = 3;
            for (int i = 0; i < countOfNumber; i++)
            {
                int checherNumber = int.Parse((Console.ReadLine()));
                if (checherNumber > firstNumber)
                {
                    thirdNumber = secondNumber;
                    secondNumber = firstNumber;
                    firstNumber= checherNumber;
                }
                else if (checherNumber>secondNumber)
                {
                    thirdNumber = secondNumber;
                    secondNumber = checherNumber;
                }
                else if (checherNumber>thirdNumber)
                {
                    thirdNumber = checherNumber;
                }
            }

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
        }
    }
}
