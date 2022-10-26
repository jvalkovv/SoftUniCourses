using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Citizen : IBuyer
    {
        public string name;
        private int age;
        public string Id { get; private set; }
        public string birthdate { get; private set; }
        public int Food { get; set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
            this.birthdate = birthdate;
        }


        public void BuyFood()
        {
            this.Food = 10;
        }
    }
}
