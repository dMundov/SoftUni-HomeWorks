using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secChar = char.Parse(Console.ReadLine());
            CharRangePrint(firstChar, secChar);

        }
        static void CharRangePrint(char first, char seccond)
        {

            int charForStart = Math.Min(first, seccond);
            int charForEnd = Math.Max(first, seccond);

            for (int i = charForStart+1; i < charForEnd; i++)
            {
                Console.Write((char)i+" ");
            }
            Console.WriteLine();
        }
    }
}
