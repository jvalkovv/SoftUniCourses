using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : IVehicle
    {
        private const double airConsumption = 1.6;
        private const double holeInTank = 0.95;

        private double fuel; // tank of car
        private double litersPerKm; // consumption


        public Truck(double fuel, double litersPerKm)
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
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            var realLiters = liters * holeInTank;

            this.Fuel += realLiters;
        }

        public override string ToString()
        {
            return $"Truck: {this.Fuel:f2}";
        }
    }
}
