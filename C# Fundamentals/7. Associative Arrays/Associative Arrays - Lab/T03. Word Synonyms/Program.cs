using System;
using System.Collections.Generic;

namespace T03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfCouples = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> couples = new Dictionary<string, List<string>>();

            for (int i = 0; i < countOfCouples; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (couples.ContainsKey(word))
                {
                    couples[word].Add(synonym);
                }
                else
                {

                    List<string> list = new List<string>();
                    list.Add(synonym);
                    couples.Add(word, list);

                }


            }
            foreach (var item in couples)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }

        }
    }
}
