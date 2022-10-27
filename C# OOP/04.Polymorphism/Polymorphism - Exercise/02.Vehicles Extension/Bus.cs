using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Bus : IVehicle
    {
        private double fuel;
        private double litersPerKm;
        private double airConsumption = 1.4;
        public Bus(double fuel, double litersPerKm, int tankCapacity)
        {
            this.Fuel = fuel > tankCapacity ? 0 : fuel;
            LitersPerKm = litersPerKm;
            TankCapacity = tankCapacity;
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
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }
        public void DriveEmpty(double distance)
        {
            double currConsumption = this.litersPerKm;
            double totalConsumption = distance * currConsumption;

            if (fuel > totalConsumption)
            {
                fuel -= totalConsumption;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
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
            return $"Bus: {this.Fuel:f2}";
        }
    }
}
