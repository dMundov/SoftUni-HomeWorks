using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int startingYeald = number;
            int days = 0;
            int totalAmmount = 0;

            while (100 <= startingYeald)
            {
                totalAmmount += startingYeald - 26;
                startingYeald -= 10;
                days++;         
            }
            if (totalAmmount >= 26)
            {
                totalAmmount -= 26;
            }
            Console.WriteLine($"{days}\n{totalAmmount}");
        }
    }
}
