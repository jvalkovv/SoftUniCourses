using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace E04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> attacked = new List<string>();
            List<string> defeated = new List<string>();

            string pattern =
@"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:(\d+)[^\@\-\!\:\>]*?\!(?<attackType>A|D){1}\![^\@\-\!\:\>]*?\-\>(\d+)";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecrypedMassage(encryptedMessage);

                Match orderInfor = Regex.Match(decryptedMessage, pattern);

                if (orderInfor.Success)
                {
                    string planet = orderInfor.Groups["planet"].Value;
                    string atttackType = orderInfor.Groups["attackType"].Value;

                    if (atttackType == "A")
                    {
                        attacked.Add(planet);
                    }
                    else if (atttackType == "D")
                    {
                        defeated.Add(planet);
                    }
                }
            }
            PrintOut(attacked, defeated);
        }
        static void PrintOut(List<string> attacked, List<string> defeated)
        {
            Console.WriteLine($"Attacked planets: {attacked.Count}");

            foreach (var planetName in attacked.OrderBy(name=>name))
            {
                Console.WriteLine($"-> {planetName}");
            }


            Console.WriteLine($"Destroyed planets: {defeated.Count}");
        
            foreach (var planet in defeated.OrderBy(name => name))
            {
                Console.WriteLine($"-> {planet}");
            }

        }
        static string DecrypedMassage(string encryptMassage)
        {
            StringBuilder dectryptedMassage = new StringBuilder();

            int deccryptionKey = GetDecryptKey(encryptMassage);

            foreach (char currChar in encryptMassage)
            {
                char decryptedChar = (char)(currChar - deccryptionKey);
                dectryptedMassage.Append(decryptedChar);
            }
            return dectryptedMassage.ToString();

        }

        static int GetDecryptKey(string encryptMassage)
        {
            string pattern = @"[star]{1}";
            MatchCollection matches
                = Regex.Matches(encryptMassage, pattern, RegexOptions.IgnoreCase);

            return matches.Count;
        }
    }
}
