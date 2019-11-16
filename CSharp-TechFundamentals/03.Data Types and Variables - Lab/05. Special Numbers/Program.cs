using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                int lastDigit = num % 10;
                int middleDigit = (num / 10) % 10;
                int firstDigit = middleDigit / 10;

                int sum = lastDigit + middleDigit + firstDigit;
                if (sum == 5 ||
                    sum == 7 ||
                    sum == 11)
                {
                    Console.WriteLine($"{num} -> True");
                }
                else
                {
                    Console.WriteLine($"{num} -> False");
                }
            }
        }
    }
}