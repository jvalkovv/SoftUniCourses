using System;

namespace L01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string cmd;

            while ((cmd = Console.ReadLine()) != "end")
            {
                string reversed = string.Empty;

                for (int i = cmd.Length - 1; i >= 0; i--)
                {
                    reversed += cmd[i];
                }
               
                Console.WriteLine($"{cmd} = {reversed}");

            }

        }
    }
}
