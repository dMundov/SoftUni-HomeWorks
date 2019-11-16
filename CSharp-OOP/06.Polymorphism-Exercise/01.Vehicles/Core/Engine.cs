using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Models;

namespace Vehicles.Core
{
    class Engine
    {
        public void Run()
        {
            string[] carDetails = Console.ReadLine()
              .Split();
            string[] truckDetails = Console.ReadLine()
              .Split();

            var car = this.MakeNewCar(carDetails);
            var truck = this.MakeNewTruck(truckDetails);

            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommands; i++)
            {
                string[] commandInput = Console.ReadLine()
                    .Split();

                string command = commandInput[0];
                string commandType = commandInput[1];

                if (command == "Drive")
                {
                    double distance = double.Parse(commandInput[2]);

                    if (commandType == "Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }
                    else
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                }
                else
                {
                    double fuelAmount = double.Parse(commandInput[2]);
                    if (commandType == "Car")
                    {
                        car.Refuel(fuelAmount);
                    }
                    else
                    {
                        truck.Refuel(fuelAmount);
                    }

                }

            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        public Car MakeNewCar(string[] input)
        {         

            double carFuelQty = double.Parse(input[1]);
            double carFuelConsumption = double.Parse(input[2]);

            return new Car(carFuelQty, carFuelConsumption);
        }
        public Truck MakeNewTruck(string[] inputDetails)
        {  

            double truckFuelQty = double.Parse(inputDetails[1]);
            double truckFuelConsumption = double.Parse(inputDetails[2]);

            return new Truck(truckFuelQty, truckFuelConsumption);
        }
    }
}

    

