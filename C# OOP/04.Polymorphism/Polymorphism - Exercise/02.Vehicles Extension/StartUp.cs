using System;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carParam = Console.ReadLine().Split();
            double fuelQuantityCar = double.Parse(carParam[1]);
            double literPerKmCar = double.Parse(carParam[2]);
            int tankCapacityCar = int.Parse(carParam[3]);
            Car car = new Car(fuelQuantityCar, literPerKmCar, tankCapacityCar);

            string[] truckParam = Console.ReadLine().Split();
            double fuelQuantityTruck = double.Parse(truckParam[1]);
            double literPerKmTruck = double.Parse(truckParam[2]);
            int tankCapacityTruck = int.Parse(truckParam[3]);
            Truck truck = new Truck(fuelQuantityTruck, literPerKmTruck, tankCapacityTruck);

            string[] busParam = Console.ReadLine().Split();
            double fuelQuantityBus = double.Parse(busParam[1]);
            double literPerKmBus = double.Parse(busParam[2]);
            int tankCapacityBus = int.Parse(busParam[3]);
            Bus bus = new Bus(fuelQuantityBus, literPerKmBus, tankCapacityBus);
            int countOfCmd = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCmd; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                string action = cmd[0];
                string typeVehicle = cmd[1];

                if (typeVehicle == "Car")
                {
                    if (action == "Drive")
                    {
                        double distance = double.Parse(cmd[2]);
                        car.Drive(distance);
                    }
                    else if (action == "Refuel")
                    {
                        double liters = double.Parse(cmd[2]);
                        car.Refuel(liters);
                    }
                }
                else if (typeVehicle == "Truck")
                {
                    if (action == "Drive")
                    {
                        double distance = double.Parse(cmd[2]);
                        truck.Drive(distance);
                    }
                    else if (action == "Refuel")
                    {
                        double liters = double.Parse(cmd[2]);
                        truck.Refuel(liters);
                    }
                }
                else if (typeVehicle=="Bus")
                {
                    if (action=="DriveEmpty")
                    {
                        double distance = double.Parse(cmd[2]);
                        bus.DriveEmpty(distance);
                    }
                    else if(action=="Drive")
                    {
                        double distance = double.Parse(cmd[2]);
                        bus.Drive(distance);
                    }
                    else if (action == "Refuel")
                    {
                        double liters = double.Parse(cmd[2]);
                        bus.Refuel(liters);
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
