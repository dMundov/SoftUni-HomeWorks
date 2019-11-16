using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main()
        {
            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.Write($"Town {townName} has population of {population} and area {area} square km.");
            Console.WriteLine();
        }
    }
}
