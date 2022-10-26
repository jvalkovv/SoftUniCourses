using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        public int Food { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Group { get; set; }

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public void BuyFood()
        {
            this.Food = 5;
        }
    }
}
