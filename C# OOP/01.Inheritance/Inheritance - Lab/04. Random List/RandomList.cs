using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        Random rand = new Random();

        public string RandomString()
        {
            if (Count ==0)
            {
                return "Invalid counter";
            }
            var index = rand.Next(0, Count);
            var element = this[index];
            this.RemoveAt(index);

            return element;
        }
        
    }
}
