using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main()
        {
            int numOfBalls = int.Parse(Console.ReadLine());
            BigInteger maxValue = -1;
            string result = string.Empty;
            for (int i = 0; i < numOfBalls; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger value = BigInteger.Pow((snow / time), quality);
                if (value > maxValue)
                {
                    result = String.Format($"{snow} : {time} = {value} ({quality})");
                    maxValue = value;
                }
            }
            Console.WriteLine(result);
        }
    }
}