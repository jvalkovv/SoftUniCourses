using PizzaCalories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza;
            Dough dough;

            try
            {
                string[] pizzaInfo = Console.ReadLine().Split();
                string pizzaName = pizzaInfo[1];
                pizza = new Pizza(pizzaName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            try
            {
                string[] doughInfo = Console.ReadLine().Split();
                string flour = doughInfo[1];
                string bakingTech = doughInfo[2];
                double weight = double.Parse(doughInfo[3]);
                dough = new Dough(flour.ToLower(), bakingTech.ToLower(), weight);

                pizza.PizzaDough = dough;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            string toppingInfo;

            while ((toppingInfo = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] toppingParams = toppingInfo.Split();

                    string toppingName = toppingParams[1].ToLower();
                    double toppingWeight = double.Parse(toppingParams[2]);
                    Topping topping = new Topping(toppingName, toppingWeight);

                    pizza.Add(topping);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            try
            {
                Console.WriteLine($"{pizza.Name} - {pizza.PizzaCalories():f2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
   
