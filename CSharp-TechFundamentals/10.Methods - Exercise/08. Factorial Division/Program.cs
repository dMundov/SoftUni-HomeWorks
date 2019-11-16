using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());

            double result = Factorial(firstNum) / Factorial(secNum);

            Console.WriteLine($"{result:f2}");


        }
        private static double Factorial(double number)
        {
            if (number == 0)
            {
                return 1;
            }  
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
