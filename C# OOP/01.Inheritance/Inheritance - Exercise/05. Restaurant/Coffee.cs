using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters = 50;
        private const decimal CoffeePrice = 3.50m;
        public double Caffeine { get; set; }
        public Coffee(string name, double cofeine)
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            this.Caffeine = cofeine;
        }

    }
}
