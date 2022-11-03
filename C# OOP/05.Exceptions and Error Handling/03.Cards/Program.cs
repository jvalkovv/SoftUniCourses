using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> card = new Dictionary<string, string>();
            string[] validFacesCard = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] validSuitCard = { "S", "H", "D", "C" };
            string[] input = Console.ReadLine()
                .Split(", ").ToArray();

            string result;

            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    string[] cardInfo = input[i].Split();
                    string faceCard = cardInfo[0];
                    string suitCard = cardInfo[1];

                    if (!validFacesCard.Contains(faceCard) || !validSuitCard.Contains(suitCard))
                    {
                        throw new ArgumentException("Invalid card!");
                    }
                    else
                    {
                        if (suitCard == "S")
                        {
                            result = "\u2660";
                            card.Add(faceCard, result);
                        }
                        else if (suitCard == "H")
                        {
                            result = "\u2665";
                            card.Add(faceCard, result);
                        }
                        else if (suitCard == "D")
                        {
                            result = "\u2666";
                            card.Add(faceCard, result);
                        }
                        else if (suitCard == "C")
                        {
                            result = "\u2663";
                            card.Add(faceCard, result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var item in card)
            {
                Console.Write($"[{item.Key}{item.Value}] ");
            }

        }
    }
}
