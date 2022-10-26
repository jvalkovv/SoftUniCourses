using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public interface IVehicle
    {
        public abstract double Fuel { get; set; }

        public abstract double LitersPerKm { get; set; }

        public abstract void Drive(double distance);

        public abstract void Refuel(double liters);
    }
}
