using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());

            decimal difference = Math.Abs(a - b);
            if (difference >= 0.000001M)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

        }
    }
}
