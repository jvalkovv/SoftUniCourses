using System;

namespace _01._String_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string cmd;

            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] array = cmd.Split(' ');
                string action = array[0];

                if (action == "Translate")
                {
                    char currChar = char.Parse(array[1]);

                    char replacement = char.Parse(array[2]);

                    input = input.Replace(currChar, replacement);

                    Console.WriteLine(input);
                }
                bool isValid = false;

                if (action == "Includes")
                {
                    string subsIncluded = array[1];

                    if (input.Contains(subsIncluded))
                    {
                        if (!isValid)
                        {
                            isValid = false;
                        }
                        isValid = true;
                    }

                    Console.WriteLine(isValid);
                }
                else if (action == "Start")
                {
                    string startingSubs = array[1];

                    if (input.StartsWith(startingSubs))
                    {
                        if (!isValid)
                        {
                            isValid = false;
                        }
                        isValid = true;
                    }
                    Console.WriteLine(isValid);
                }
               else if (action == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                if (action == "FindIndex")
                {
                    char currChar = char.Parse(array[1]);

                    if (input.Contains(currChar))
                    {
                        int currenIndex = input.LastIndexOf(currChar);

                        Console.WriteLine(currenIndex);
                    }
                }
               else if (action=="Remove")
                {
                    int startedIndex = int.Parse(array[1]);
                    int endIndex = int.Parse(array[2]);

                    input = input.Remove(startedIndex, endIndex);
                    Console.WriteLine(input);
                }
            }
        }
    }
}