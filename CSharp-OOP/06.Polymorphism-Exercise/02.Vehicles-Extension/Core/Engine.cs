namespace Vehicles.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Vehicles.Models;
    class Engine
    {
        public void Run()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            for (int i = 1; i <= 3; i++)
            {
                string[] vehicleData = Console.ReadLine()
                    .Split();

                Vehicle vehicle = null;

                if(i==1)
                {
                   vehicle=  this.MakeNewCar(vehicleData);
                }
                else if (i==2)
                {
                    vehicle = this.MakeNewTruck(vehicleData);
                }
                else if(i==3)
                {
                    vehicle = this.MakeNewBus(vehicleData); ;
                }
                vehicles.Add(vehicle);
            } 

            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommands; i++)
            {
                string[] commandInput = Console.ReadLine()
                    .Split();

                string command = commandInput[0];
                string vehicleType = commandInput[1];

                if (command == "Drive")
                {
                    double distance = double.Parse(commandInput[2]);

                    if (vehicleType == "Car")
                    {
                        Car car = (Car)vehicles.FirstOrDefault(x => x.GetType().Name == "Car");
                        Console.WriteLine(car.Drive(distance));
                    }
                    else if (vehicleType == "Truck")
                    {
                        Truck truck = (Truck)vehicles.FirstOrDefault(x => x.GetType().Name == "Truck");
                        Console.WriteLine(truck.Drive(distance));
                    }
                    else if (vehicleType == "Bus")
                    {
                        Bus bus = (Bus)vehicles.FirstOrDefault(x => x.GetType().Name == "Bus");
                        Console.WriteLine(bus.Drive(distance));
                    }
                }

                else if (command == "Refuel")
                {
                    double fuelAmount = double.Parse(commandInput[2]);

                    try
                    {
                        if (vehicleType == "Car")
                        {
                            Car car = (Car)vehicles.FirstOrDefault(x => x.GetType().Name == "Car");
                            car.Refuel(fuelAmount);
                        }
                        else if (vehicleType == "Truck")
                        {
                            Truck truck = (Truck)vehicles.FirstOrDefault(x => x.GetType().Name == "Truck");
                            truck.Refuel(fuelAmount);
                        }
                        else if (vehicleType == "Bus")
                        {
                            Bus bus = (Bus)vehicles.FirstOrDefault(x => x.GetType().Name == "Bus");
                            bus.Refuel(fuelAmount);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (command == "DriveEmpty")
                {
                    var distance = double.Parse(commandInput[2]);

                    if (vehicleType == "Bus")
                    {
                        Bus bus = (Bus)vehicles
                            .FirstOrDefault(x => x.GetType().Name == "Bus");
                        Console.WriteLine(bus.DriveEmpty(distance));
                    }
                }
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        public Car MakeNewCar(string[] input)
        {

            double carFuelQty = double.Parse(input[1]);
            double carFuelConsumption = double.Parse(input[2]);
            int carTankCapacity = int.Parse(input[3]);

            return new Car(carFuelQty, carFuelConsumption, carTankCapacity);
        }
        public Truck MakeNewTruck(string[] inputDetails)
        {

            double truckFuelQty = double.Parse(inputDetails[1]);
            double truckFuelConsumption = double.Parse(inputDetails[2]);
            int truckTankCapacity = int.Parse(inputDetails[3]);

            return new Truck(truckFuelQty, truckFuelConsumption, truckTankCapacity);
        }
        public Bus MakeNewBus(string[] inputDetails)
        {

            double busFuelQty = double.Parse(inputDetails[1]);
            double busFuelConsumption = double.Parse(inputDetails[2]);
            int busTankCapacity = int.Parse(inputDetails[3]);

            return new Bus(busFuelQty, busFuelConsumption, busTankCapacity);
        }
    }
}



