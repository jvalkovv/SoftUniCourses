﻿namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Car car = new Car(10,50);
            SportCar sportCar = new SportCar(10, 60);
            System.Console.WriteLine(sportCar);
        }
    }
}
