using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            decimal sum = 0;
            
            while(num != 0)
            {
                double number = double.Parse(Console.ReadLine());
                sum += (decimal)number;
                num--;
            }
            Console.WriteLine((sum));
        }
    }
}
