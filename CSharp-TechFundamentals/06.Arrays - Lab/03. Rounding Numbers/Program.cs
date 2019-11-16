using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double roundNum = Math.Round(numbers[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {roundNum}");
            }
        }
    }
}
