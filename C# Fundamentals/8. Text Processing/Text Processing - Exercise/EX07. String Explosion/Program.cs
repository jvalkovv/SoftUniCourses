using System;
using System.Text;

namespace EX07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            StringBuilder outputText = new StringBuilder();
            int bombPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currElement = input[i];

                if (currElement == '>')
                {
                    int currBombPower = GetValueFromChar(input[i + 1]);

                    outputText.Append(currElement);
                    bombPower += currBombPower;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        outputText.Append(currElement);
                    }

                }
            }
            Console.WriteLine(outputText);
        }

        static int GetValueFromChar(char ch)
        {

            return (int)ch - 48;
        }
    }
}
