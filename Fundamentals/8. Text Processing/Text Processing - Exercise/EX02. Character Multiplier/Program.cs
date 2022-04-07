using System;
using System.Collections.Generic;

namespace EX02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] line = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string firstElement = line[0];
            string secondElement = line[1];

            int minLength = Math.Min(firstElement.Length, secondElement.Length);    
            int maxLength = Math.Max(firstElement.Length, secondElement.Length);

            int sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                int multiply = firstElement[i] * secondElement[i];

                sum+=multiply;
            }
            if (firstElement.Length != secondElement.Length)
            {
                string longerString = string.Empty;
                
                if (firstElement.Length>secondElement.Length)
                {
                    longerString = firstElement;
                }
                else
                {
                    longerString = secondElement;
                }

                for (int i = minLength; i < maxLength; i++)
                {
                    sum += longerString[i];
                }

            }

            Console.WriteLine(sum);
        }


    }
}
