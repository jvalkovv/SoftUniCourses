using System;
using System.Collections.Generic;

namespace T09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            bool isPalinInteger = false;

            while (number != "END")
            {
                Console.WriteLine(PrintPalindrome(number, isPalinInteger)
                    .ToString().ToLower());
                number = Console.ReadLine();
            }
        }

        static bool PrintPalindrome(string number, bool isPalinInteger)
        {

            string reverseNumber = string.Empty;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                char symbol = number[i];
                reverseNumber += symbol;
            }
            if (reverseNumber == number)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
