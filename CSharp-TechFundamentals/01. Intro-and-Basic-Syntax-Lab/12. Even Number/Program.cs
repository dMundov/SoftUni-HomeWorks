using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            while (true)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    num = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
