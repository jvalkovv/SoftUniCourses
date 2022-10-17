using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();
            stackOfStrings.Push("Apple");
            stackOfStrings.Push("Apple1");
            stackOfStrings.Push("Apple2");

            Console.WriteLine(stackOfStrings.IsEmpty());
            Console.WriteLine(stackOfStrings.AddRange());
        }
    }
}
