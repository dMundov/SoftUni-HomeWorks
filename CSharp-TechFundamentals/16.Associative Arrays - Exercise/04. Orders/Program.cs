using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, double[]> priceList = new Dictionary<string, double[]>();

            while(true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                double price = 0;
                int qauntity = 0;
                if (command.Length > 1)
                {
                    price = double.Parse(command[1]);
                    qauntity = int.Parse(command[2]);
                }
                if(command[0]=="buy")
                {
                    break;
                }
                else
                {
                    if(!priceList.ContainsKey(command[0]))
                    {
                        priceList.Add(command[0], new double[2]);
                    }
                    priceList[command[0]][0] = price;
                    priceList[command[0]][1] += qauntity;
                    
                }
            }
            foreach (var kVp in priceList)
            {
                Console.WriteLine($"{kVp.Key} -> {(kVp.Value[0]*kVp.Value[1]):f2}");
            }
        }
    }
}
