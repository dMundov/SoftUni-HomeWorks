using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            

            double[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse).ToArray();

            Dictionary<double, int> numCount = new Dictionary<double, int>();

            foreach (double num in numbers)
            {
                if (numCount.ContainsKey(num))
                {
                    numCount[num]++;
                }
                else
                {
                    numCount[num] = 1;
                }
            }
            foreach (KeyValuePair<double, int> num in numCount)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
