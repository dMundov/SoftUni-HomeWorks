using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main()
        {
            int numPersons = int.Parse(Console.ReadLine());

            List<string> personNames = new List<string>();

            string[] command = new string[4];

            for (int i = 0; i < numPersons; i++)
            {
                command = Console.ReadLine().Split(" ").ToArray();

                if (command[2] == "going!")
                {
                    if (personNames.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        personNames.Add(command[0]);
                    }
                }
                if (command[2] != "going!")
                {
                    if (personNames.Contains(command[0]))
                    {
                        personNames.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }
            foreach (var item in personNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
