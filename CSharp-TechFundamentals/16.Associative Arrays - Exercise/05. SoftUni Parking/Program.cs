using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, string> userPlate = new Dictionary<string, string>();

            for (int i = 0; i < num; i++)
            {
                string[] inputData = Console.ReadLine().Split().ToArray();
                string command = inputData[0];
                string user = inputData[1];
                string plateNumber = "";

                if (command == "register")
                {
                    if (inputData.Length > 2)
                    {
                        plateNumber = inputData[2];
                    }
                    if (userPlate.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                    if (!userPlate.ContainsKey(user))
                    {
                        userPlate.Add(user, plateNumber);
                        Console.WriteLine($"{user} registered {plateNumber} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (userPlate.ContainsKey(user))
                    {
                        userPlate.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }
            foreach (var kVp in userPlate)
            {
                Console.WriteLine($"{kVp.Key} => {kVp.Value}");
            }
        }
    }
}
