using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            int maxPassengers = int.Parse(Console.ReadLine());
            string[] command = new string[2];

            while (true)
            {
                string input = Console.ReadLine();

                command = input.Split(" ").ToArray();
                if (input == "end")
                {
                    break;
                }
                command = input.Split(" ").ToArray();
                if(command[0]=="Add")
                {                    
                    int wagonsToAdd = int.Parse(command[1]);

                    if(command[0]=="Add")
                    {
                        wagons.Add(wagonsToAdd);
                    }
                }
                else
                {
                    int passengersToAdd = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengersToAdd <= maxPassengers)
                        {
                            wagons[i] = wagons[i] + passengersToAdd;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
