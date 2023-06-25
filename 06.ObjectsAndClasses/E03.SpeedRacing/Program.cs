using System;
using System.Collections.Generic;
using System.Linq;

namespace M03.SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");
                string model = tokens[0];
                double fuel = double.Parse(tokens[1]);
                double fuelPerKM = double.Parse(tokens[2]);
                Car oneCar = new Car(model, fuel, fuelPerKM);
                cars.Add(oneCar);
            }
            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" ");
                string model = tokens[1];
                double kilometers = double.Parse(tokens[2]);
                Car currentCar = cars.Find(x => x.Model == model);
                currentCar.IsCarTravelPossible(kilometers);
            }
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
    class Car
    {
        public Car(string model, double fuel, double fuelPerKM)
        {
            Model = model;
            FuelAmount = fuel;
            FuelPerKM = fuelPerKM;
            TraveledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelPerKM { get; set; }
        public double TraveledDistance { get; set; }

        public void IsCarTravelPossible(double kilometers)
        {
            if (FuelAmount - FuelPerKM * kilometers >= 0)
            {
                FuelAmount -= FuelPerKM * kilometers;
                TraveledDistance += kilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
