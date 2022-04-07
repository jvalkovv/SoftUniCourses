using System;
using System.Text;

namespace EX06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            StringBuilder newWord = new StringBuilder();


            for (int i = 0; i < line.Length - 1; i++)
            {
                char currChar = line[i];
                char nextChar = line[i + 1];

                if (currChar != nextChar)
                {
                    newWord.Append(currChar);
                }

            }
            newWord.Append(line[line.Length - 1]);

            Console.WriteLine(newWord);
        }

    }
}
