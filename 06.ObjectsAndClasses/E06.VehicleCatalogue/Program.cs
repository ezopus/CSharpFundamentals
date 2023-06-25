using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace E06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" ");
                string type = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                int horsepower = int.Parse(tokens[3]);
                Vehicle oneVehicle = new Vehicle(type, model, color, horsepower);
                vehicles.Add(oneVehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle foundVehicle = vehicles.First(x => x.Model == input);
                PrintVehicle(foundVehicle);
            }

            double averageHpCars = vehicles
                .Where(x => x.Type.ToLower() == "car")
                .Select(hp => hp.Horsepower)
                .DefaultIfEmpty()
                .Average();
            double averageHpTrucks = vehicles
                .Where(x => x.Type.ToLower() == "truck")
                .Select(hp => hp.Horsepower)
                .DefaultIfEmpty()
                .Average(); ;
            
            Console.WriteLine($"Cars have average horsepower of: {averageHpCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHpTrucks:f2}.");


        }

        private static void PrintVehicle(Vehicle foundVehicle)
        {
            Console.WriteLine($"Type: {TitleLetter(foundVehicle.Type)}");
            Console.WriteLine($"Model: {foundVehicle.Model}");
            Console.WriteLine($"Color: {foundVehicle.Color}");
            Console.WriteLine($"Horsepower: {foundVehicle.Horsepower}");
        }

        private static string TitleLetter(string foundVehicleType)
        {
            string firstLetter = foundVehicleType.Substring(0, 1).ToUpper();
            string remainingLetters = foundVehicleType.Substring(1).ToLower();
            return firstLetter + remainingLetters;
        }

        public class Vehicle
        {
            public Vehicle(string type, string model, string color, int horsepower)
            {
                Type = type;
                Model = model;
                Color = color;
                Horsepower = horsepower;
            }
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }

        }
    }
}
