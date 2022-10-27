using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : IVehicle
    {
        private double airConsumption = 0.9;
        private double fuel; // tank of car
        private double litersPerKm; // consumption


        public Car(double fuel, double litersPerKm, int tankCapacity)
        {
            this.Fuel = fuel > tankCapacity ? 0 : fuel;
            this.LitersPerKm = litersPerKm;
            this.TankCapacity = tankCapacity;

        }
        public double Fuel
        {

            get { return this.fuel; }
            set
            {
                this.fuel = value;
            }
        }
        public double LitersPerKm
        {
            get { return this.litersPerKm; }
            set
            {
                this.litersPerKm = value;
            }
        }

        public int TankCapacity { get; set; }

        public void Drive(double distance)
        {
            double currConsumption = this.litersPerKm + airConsumption;
            double totalConsumption = distance * currConsumption;

            if (fuel > totalConsumption)
            {
                fuel -= totalConsumption;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            double currFuel = this.Fuel + liters;
            if (liters < 1)
            {
                Console.WriteLine($"Fuel must be a positive number");
            }
            else if (currFuel <= TankCapacity)
            {
                this.Fuel += liters;
            }
            else
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
        }

        public override string ToString()
        {
            return $"Car: {this.Fuel:f2}";
        }
    }
}
