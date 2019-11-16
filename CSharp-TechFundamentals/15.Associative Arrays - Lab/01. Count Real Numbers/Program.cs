using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToArray(); 

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (int number in numbers)
            {
                if(counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number, 1);
                }
            }
            foreach (KeyValuePair<double, int> number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
