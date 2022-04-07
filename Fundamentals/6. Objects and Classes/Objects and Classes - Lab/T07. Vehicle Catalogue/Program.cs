using System;
using System.Collections.Generic;
using System.Linq;
namespace T07._Vehicle_Catalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }

    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

    }
    class Catalog
    {

        public List<Car> Cars = new List<Car>();

        public List<Truck> Trucks = new List<Truck>();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog vehicleObject = new Catalog();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = input[0];
                string brand = input[1];
                string model = input[2];
                int specification = int.Parse(input[3]);

                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, specification);
                    vehicleObject.Cars.Add(newCar);
                }
                else if (type=="Truck")
                {
                    Truck newTruck = new Truck(brand, model, specification);
                    vehicleObject.Trucks.Add(newTruck);
                }
            }
            vehicleObject.Cars = vehicleObject.Cars.OrderBy(x => x.Brand).ToList();
            vehicleObject.Trucks = vehicleObject.Trucks.OrderBy(x => x.Brand).ToList();

            if (vehicleObject.Cars.Count != 0)
            {
                Console.WriteLine("Cars:");

                foreach (var car in vehicleObject.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (vehicleObject.Trucks.Count != 0)
            {
                Console.WriteLine("Trucks:");

                foreach (var truck in vehicleObject.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
