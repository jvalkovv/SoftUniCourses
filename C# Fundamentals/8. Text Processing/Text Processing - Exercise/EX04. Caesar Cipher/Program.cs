using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string encrypted = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char currLetter = input[i];

                currLetter += (char)3;

                encrypted += currLetter;
            }
            Console.WriteLine(encrypted);

        }
    }
}
