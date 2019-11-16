using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bigArray = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            List<int> numbers = new List<int>();
            for (int i = 0; i < bigArray.Count; i++)
            {
                numbers = bigArray[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                for (int j = 0; j < numbers.Count; j++)
                {
                    Console.Write($"{numbers[j]} ");
                }
            }
            Console.WriteLine();
        }
    }
}