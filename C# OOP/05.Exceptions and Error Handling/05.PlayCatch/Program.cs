using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int exceptionCounter = 0;

            while (true)
            {
                if (exceptionCounter == 3)
                {
                    break;
                }
                string[] cmd = Console.ReadLine().Split().ToArray();

                try
                {
                    var action = cmd[0];

                    if (action == "Replace")
                    {
                        int index = int.Parse(cmd[1]);
                        int element = int.Parse(cmd[2]);
                        input.RemoveAt(index);
                        input.Insert(index, element);

                    }
                    if (action == "Show")
                    {
                        int index = int.Parse(cmd[1]);
                        Console.WriteLine(input.ElementAt(index));

                    }
                    if (action == "Print")
                    {
                        int startIndex = int.Parse(cmd[1]);
                        int endIndex = int.Parse(cmd[2]);
                        List<int> printElement = new List<int>();

                        if (startIndex < 0 || endIndex > input.Count - 1)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        else
                        {
                            for (int i = 0; i < input.Count; i++)
                            {
                                if (i >= startIndex && i <= endIndex)
                                {
                                    printElement.Add(input[i]);
                                }
                            }

                            Console.WriteLine(String.Join(", ", printElement));
                        }

                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionCounter++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionCounter++;
                }
            }

            Console.WriteLine(String.Join(", ", input));
        }
    }
}
