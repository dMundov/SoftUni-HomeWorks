using System;
using System.Numerics;

namespace _08._Math_Power
{
    class Program
    {
        static void Main()
        {
            double value = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            MathPower(value, power);

        }

        static double MathPower(double value, int power)
        {
            double result = 0d;
            result =Math.Pow(value, power);
            Console.WriteLine(result);
            return result;
        }
    }
}
