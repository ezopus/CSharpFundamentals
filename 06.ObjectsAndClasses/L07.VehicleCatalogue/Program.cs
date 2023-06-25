using System;
using System.Collections.Generic;
using System.Linq;

namespace L07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split("/");
                string typeOfVehicle = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int weightOrHorsePower = int.Parse(tokens[3]);
                if (typeOfVehicle == "Car")
                {
                    Car oneCar = new Car(brand, model, weightOrHorsePower);
                    cars.Add(oneCar);
                }
                else
                {
                    Truck oneTruck = new Truck(brand, model, weightOrHorsePower);
                    trucks.Add(oneTruck);
                }
            }

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in cars.OrderBy(x => x.CarBrand))
                {
                    Console.WriteLine($"{car.CarBrand}: {car.CarModel} - {car.CarHorsePower}hp");
                }
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in trucks.OrderBy(x => x.TruckBrand))
                {
                    Console.WriteLine($"{truck.TruckBrand}: {truck.TruckModel} - {truck.TruckWeight}kg");
                }
            }

        }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            TruckBrand = brand;
            TruckModel = model;
            TruckWeight = weight;
        }
        public string TruckBrand { get; set; }
        public string TruckModel { get; set; }
        public int TruckWeight { get; set; }

    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            CarBrand = brand;
            CarModel = model;
            CarHorsePower = horsePower;
        }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int CarHorsePower { get; set; }
    }
}
