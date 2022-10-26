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

            Car car = new Car(fuelQuantityCar, literPerKmCar);
            string[] truckParam = Console.ReadLine().Split();
            double fuelQuantityTruck = double.Parse(truckParam[1]);
            double literPerKmTruck = double.Parse(truckParam[2]);
            Truck truck = new Truck(fuelQuantityTruck, literPerKmTruck);            

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
                    else if (action=="Refuel")
                    {
                        double liters = double.Parse(cmd[2]);
                        car.Refuel(liters);
                    }
                }
               else  if (typeVehicle == "Truck")
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
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }
    }
}
