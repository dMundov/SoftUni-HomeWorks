using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int digit = 0;
            int sum = 0;
            while (number > 0)
            {
                digit = number % 10;
                sum += digit;
                number /= 10;

            }
            Console.WriteLine(sum);
        }
    }
}
