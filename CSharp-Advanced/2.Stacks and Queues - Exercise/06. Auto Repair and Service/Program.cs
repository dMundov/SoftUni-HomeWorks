using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _06._Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            string[] inputCars = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Queue<string> carsForService = new Queue<string>(inputCars);
            Stack<string> servicedCars = new Stack<string>();

            while(true)
            {
                string command = Console.ReadLine();
                if(command=="End")
                {
                    break;
                }
                else
                {
                    if(command== "Service"&&carsForService.Count>0)
                    {
                        string car = carsForService.Peek();
                        servicedCars.Push(carsForService.Dequeue());
                        Console.WriteLine($"Vehicle {car} got served.");
                    }
                    else if(command.Contains("-"))
                    {
                        string[] carInfo = command.Split("-").ToArray();
                        string car = carInfo[1];
                        if(servicedCars.Contains(car))
                        {
                            Console.WriteLine("Served.");
                        }
                        else
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                    }
                    else if(command== "History")
                    {
                        Console.WriteLine(string.Join(", ",servicedCars));
                    }
                }
            }
            if (carsForService.Any())
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", carsForService)}");
            }
            if (servicedCars.Any())
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", servicedCars)}");
            }
        }
    }
}
