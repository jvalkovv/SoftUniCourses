using System;
using System.Collections.Generic;
using System.Linq;

namespace E05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i < counter; i++)
            {
                string digit = Console.ReadLine();
                int digitLenght = digit.Length;

                char singleChar = digit.ElementAt(0);
                int mainDigit = (int)Char.GetNumericValue(singleChar);

                int offset = (mainDigit - 2) * 3;

                if (mainDigit==8 || mainDigit==9)
                {
                    offset++;
                }

                int letterIndex = offset + digitLenght - 1;

                int letterCode = letterIndex + 97;

                char letter = (char)letterCode;

                if (mainDigit==0)
                {
                    letter = (char)(mainDigit + 32);
                }
                result += letter;
            }

            Console.WriteLine(result);
        }
    }
}
