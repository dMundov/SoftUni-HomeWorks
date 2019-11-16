using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    public class Program
    {
        public class Vehicle
        {
            public Vehicle(string type, string model, string color, int horsePower)
            {
                Type = type;
                Model = model;
                Color = color;
                HorsePower = horsePower;
            }
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }

            public override string ToString()
            {
                string vehicleString = $"Type: {(Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                    $"Model: {Model}{Environment.NewLine}" +
                                    $"Color: {Color}{Environment.NewLine}" +
                                    $"Horsepower: {HorsePower}";
                return vehicleString;

            }
        }
        public static void Main()
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            while (true)
            {
                string[] inputCatalogue = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (inputCatalogue[0] == "End")
                {
                    break;
                }

                string type = inputCatalogue[0].ToLower();
                string model = inputCatalogue[1];
                string color = inputCatalogue[2].ToLower();
                int horsePower = int.Parse(inputCatalogue[3]);
                Vehicle currentVehicle = new Vehicle(type, model, color, horsePower);
                catalogue.Add(currentVehicle);
            }
            while (true)
            {
                string inputData = Console.ReadLine();
                if (inputData == "Close the Catalogue")
                {
                    break;
                }
                Console.WriteLine(catalogue.Find(x => x.Model == inputData));
            }
            List<Vehicle> carsCatalogue = catalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> trucksCatalogue = catalogue.Where(x => x.Type == "truck").ToList();
            double totalCarsHorsePower = 0;
            double totalTrucksHorsePower = 0;

            foreach (Vehicle car in carsCatalogue)
            {
                totalCarsHorsePower += car.HorsePower;
            }
            foreach (Vehicle truck in trucksCatalogue)
            {
                totalTrucksHorsePower += truck.HorsePower;
            }

            double averageCarsHorsepower = totalCarsHorsePower / carsCatalogue.Count;
            double averageTrucksHorsepower = totalTrucksHorsePower / trucksCatalogue.Count;

            if (carsCatalogue.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (trucksCatalogue.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}