using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            int total = 0;
            int numOfi = 0;
            bool divided = false;

            for (int i = 1; i <= digit; i++)
            {
                numOfi = i;
                while (numOfi > 0)
                {
                    total += numOfi % 10;
                    numOfi /= 10;
                }
                divided = total == 5 || total == 7 || total == 11;
                Console.WriteLine($"{i} -> {divided}");

                total = 0;
            }
        }
    }
}