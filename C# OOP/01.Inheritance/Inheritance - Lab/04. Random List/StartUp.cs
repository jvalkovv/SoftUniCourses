using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList rndList = new RandomList();

            rndList.Add("Apple");
            rndList.Add("Apple1");
            rndList.Add("Apple2");
            rndList.Add("Apple3");

            Console.WriteLine(rndList.RandomString());
            Console.WriteLine(rndList.RandomString());
            Console.WriteLine(rndList.RandomString());
            Console.WriteLine(rndList.RandomString());

        }
    }
}
