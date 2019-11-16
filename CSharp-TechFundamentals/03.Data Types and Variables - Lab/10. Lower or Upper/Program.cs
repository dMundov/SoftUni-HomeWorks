using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main()
        {
            char line = char.Parse(Console.ReadLine());

            if((int)line>=65 && (int)line<=90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
