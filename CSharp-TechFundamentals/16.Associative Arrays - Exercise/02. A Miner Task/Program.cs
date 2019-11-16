using System;
using System.Linq;
using System.Collections.Generic;



namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main()
        {

            int quantity = 0;
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }
                else
                {
                      quantity = int.Parse(Console.ReadLine());
                }
               
                if(!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }
                resources[resource] += quantity;
                
            }
            foreach (var kVp in resources)
            {
                Console.WriteLine($"{kVp.Key} -> {kVp.Value}");
            }
        }
    }
}
