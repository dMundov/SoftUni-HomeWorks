using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main()
        {
            char line1 = char.Parse(Console.ReadLine());
            char line2 = char.Parse(Console.ReadLine());
            char line3 = char.Parse(Console.ReadLine());

            Console.Write($"{line1}{line2}{line3}");

            Console.WriteLine();
        }
    }
}
