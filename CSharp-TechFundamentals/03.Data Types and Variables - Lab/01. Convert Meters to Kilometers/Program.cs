using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main()
        {
            double meters = double.Parse(Console.ReadLine());

            decimal kilometers = Math.Abs((decimal)meters / 1000);


            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
