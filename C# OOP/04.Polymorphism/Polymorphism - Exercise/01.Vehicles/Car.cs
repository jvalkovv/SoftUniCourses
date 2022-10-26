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


        public Car(double fuel, double litersPerKm)
        {
            this.Fuel = fuel;
            this.LitersPerKm = litersPerKm;

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
            this.Fuel += liters;
        }

        public override string ToString()
        {
            return $"Car: {this.Fuel:f2}";
        }
    }
}
