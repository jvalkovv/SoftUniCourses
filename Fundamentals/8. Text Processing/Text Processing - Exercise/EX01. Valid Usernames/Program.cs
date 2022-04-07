using System;
using System.Collections.Generic;
using System.Linq;
namespace EX01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] userNames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsername = new List<string>();

            for (int i = 0; i < userNames.Length; i++)
            {
                string currenUser = userNames[i];

                if (currenUser.Length >= 3 && currenUser.Length <= 16)
                {
                    bool isValidUser = true;

                    if (isValidUser)
                    {
                        foreach (var symbol in currenUser)
                        {
                            if (char.IsLetterOrDigit(symbol)
                                || symbol == '-' || symbol == '_')
                            {
                                isValidUser = true;
                            }
                            else
                            {
                                isValidUser = false;
                                break;
                            }
                        }
                    }
                    if (isValidUser)
                    {
                        validUsername.Add(currenUser);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, validUsername));
        }
    }
}
