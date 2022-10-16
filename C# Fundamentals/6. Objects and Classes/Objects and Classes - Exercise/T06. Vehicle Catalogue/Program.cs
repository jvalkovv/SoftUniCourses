using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Vehicle_Catalogue
{
    internal class Program
    {
        class Vehicle
        {
            public Vehicle(string typeOfVehicle, string model, string color, int horsePower)
            {
                this.TypeOfVehicle = typeOfVehicle;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower;

            }

            public string TypeOfVehicle { get; set; }
            public string Model { get; set; }

            public string Color { get; set; }

            public int HorsePower { get; set; }

            public override string ToString()
            {
                string output = $"Type: {(this.TypeOfVehicle == "car" ? "Car" : "Truck")}" +
                                $"{Environment.NewLine}" +
                                $"Model: {this.Model}{Environment.NewLine}" +
                                $"Color: {this.Color}{Environment.NewLine}" +
                                $"Horsepower: {this.HorsePower}";

                return output;
            }
        }
        static void Main(string[] args)
        {
            List<Vehicle> vehiclePerformance = new List<Vehicle>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] action = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string currTypeOfVehicle = action[0].ToLower();
                string currModelOfVehicle = action[1];
                string currColorOfVehicle = action[2].ToLower();
                int currHpOfVehicle = int.Parse(action[3]);


                Vehicle currVehicle = new Vehicle
                    (currTypeOfVehicle, currModelOfVehicle, currColorOfVehicle, currHpOfVehicle);
                vehiclePerformance.Add(currVehicle);


                command = Console.ReadLine();
            }

            while (true)
            {
                string model = Console.ReadLine();

                if (model == "Close the Catalogue")
                {
                    break;
                }

                Console.WriteLine(vehiclePerformance.Find(x => x.Model == model));
            }

            List<Vehicle> onlyCars = vehiclePerformance.Where(c => c.TypeOfVehicle == "car").ToList();

            List<Vehicle> onlyTrucks = vehiclePerformance.Where(t => t.TypeOfVehicle == "truck").ToList();

            double sumOfCarsHP = 0;
            double sumOfTrucskHp = 0;

            foreach (var car in onlyCars)
            {
                sumOfCarsHP += car.HorsePower;
            }

            foreach (var truck in onlyTrucks)
            {
                sumOfTrucskHp += truck.HorsePower;
            }
            double averageCarsHP = sumOfCarsHP / onlyCars.Count;
            double averageTrucksHP = sumOfTrucskHp / onlyTrucks.Count;

            if (onlyCars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHP:f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (onlyTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHP:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}
