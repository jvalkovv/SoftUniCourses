using System;

namespace T01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random generator = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int radndomIndex = generator.Next(0, words.Length);
                string currenWord = words[i];
                words[i] = words[radndomIndex];
                words[radndomIndex] = currenWord;
            }

            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
