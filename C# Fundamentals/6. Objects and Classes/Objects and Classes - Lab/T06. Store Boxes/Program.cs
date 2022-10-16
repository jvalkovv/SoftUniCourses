using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._StoreBoxes
{
    internal class Program
    {
        class Item
        {
            public string Name { get; set; }

            public decimal Price { get; set; }
        }

        class Box
        {
            public Box()
            {
                Item = new Item();
            }
            public string SerialNumber { get; set; }

            public Item Item { get; set; }

            public int QuantityOfItem { get; set; }

            public decimal PriceForABox
            {
                get
                {
                    return this.QuantityOfItem * this.Item.Price;
                }
            }
        }
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] parts = command.Split();

                string serialNumber = parts[0];
                string name = parts[1];
                int itemQuantity = int.Parse(parts[2]);
                decimal itemPrice = decimal.Parse(parts[3]);

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = new Item()
                    {
                        Name = name,
                        Price = itemPrice,
                    },
                    QuantityOfItem = itemQuantity
                };

                boxes.Add(box);
            }

            List<Box> orderedBoxes = boxes
                .OrderByDescending(b => b.PriceForABox)
                .ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.QuantityOfItem}");
                Console.WriteLine($"-- ${ box.PriceForABox:f2}");
            }
        }
    }
}
