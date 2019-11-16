using System;

namespace _02._Passed
{
    class Program
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());

            if (num >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
