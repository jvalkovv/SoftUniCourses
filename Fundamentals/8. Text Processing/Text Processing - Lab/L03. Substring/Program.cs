using System;

namespace L03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string wordToRemove = Console.ReadLine();

            string text = Console.ReadLine();

            while (text.Contains(wordToRemove))
            {
                int ourIndex = text.IndexOf(wordToRemove);

                text = text.Remove(ourIndex, wordToRemove.Length);

            }

            Console.WriteLine(text);

        }
    }
}
