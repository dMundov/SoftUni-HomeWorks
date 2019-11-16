using System;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main()
        {
            char firstLine = char.Parse(Console.ReadLine());
            char secLine = char.Parse(Console.ReadLine());
            char thirdLine = char.Parse(Console.ReadLine());

            Console.Write($"{thirdLine} {secLine} {firstLine}");
            Console.WriteLine();
        }
    }
}
