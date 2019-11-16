using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                result = ((i + i) - 1);
                Console.WriteLine(result);
                sum+=result;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
