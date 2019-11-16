using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int allowAmount = 255;
            int allPourLiters = 0;

            for (int i = 1; i <= num; i++)
            {
                int pourLitrers = int.Parse(Console.ReadLine());
                if((allowAmount-pourLitrers)>= 0)
                {
                    allowAmount -= pourLitrers;
                    allPourLiters += pourLitrers;
                }
                else
                {
                    Console.WriteLine($"Insufficient capacity!");
                }               
            }
            Console.WriteLine(allPourLiters);
        }
    }
}
