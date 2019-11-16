using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main()
        {
            decimal paunds = decimal.Parse(Console.ReadLine());

            decimal usDollars = paunds * 1.31M;

            Console.WriteLine($"{usDollars:f3}");
        }
    }
}
