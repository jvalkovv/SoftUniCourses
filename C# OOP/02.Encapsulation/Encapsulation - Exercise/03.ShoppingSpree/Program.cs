using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> persons = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            try
            {
                string[] peopleInfo = Console.ReadLine().Split(';');

                for (int i = 0; i < peopleInfo.Length; i++)
                {
                    string[] personInfo = peopleInfo[i].Split('=');
                    string name = personInfo[0];
                    decimal money = decimal.Parse(personInfo[1]);
                    Person person = new Person(name, money);
                    persons[name] = person;
                }

                string[] productInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < productInfo.Length; i++)
                {
                    string[] currProduct = productInfo[i].Split('=');
                    string productName = currProduct[0];
                    decimal productCost = decimal.Parse(currProduct[1]);
                    Product product = new Product(productName, productCost);
                    products[productName] = product;
                }

                string cmd = Console.ReadLine();

                while (cmd != "END")
                {
                    string[] data = cmd.Split();
                    string personName = data[0];
                    string productName = data[1];
                    decimal personMoney = persons[personName].Money;
                    decimal productCost = products[productName].Cost;

                    if (personMoney - productCost < 0)
                    {
                        Console.WriteLine($"{personName} can't afford {productName}");
                    }
                    else
                    {
                        persons[personName].Money -= productCost;
                        Console.WriteLine($"{personName} bought {productName}");
                        persons[personName].BagOfProducts.Add(productName);

                    }

                    cmd = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            foreach (var person in persons)
            {
                Console.Write($"{person.Key} - ");

                if (person.Value.BagOfProducts.Count == 0)
                {
                    Console.WriteLine("Nothing bought");
                }
                else
                {
                    Console.WriteLine(String.Join(", ", person.Value.BagOfProducts));
                }
            }
        }
    }
}
