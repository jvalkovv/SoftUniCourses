using System;

namespace Т06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine((ReturnMiddleCharacter(input)));
        }

        static string ReturnMiddleCharacter(string input)
        {
            int len = input.Length;
            string result = string.Empty;
            if (len % 2 == 1)
            {
                result = input[input.Length / 2].ToString();
            }
            else
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }
            return result;
        }
    }
}
