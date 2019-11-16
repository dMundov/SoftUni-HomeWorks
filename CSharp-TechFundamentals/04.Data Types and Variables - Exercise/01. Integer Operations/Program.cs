using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int sum = first + second;
            sum /= third;
            int totalSum = sum * fourth;

            Console.WriteLine(totalSum);
        }
    }
}
