using System;

namespace L04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToReplace = Console.ReadLine()
                .Split(new char [] {' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();
            
            foreach (var word in wordsToReplace)
            {
             text = text.Replace(word, new string ('*', word.Length));  
            } 
            
            Console.WriteLine(text);
        }
    }
}
