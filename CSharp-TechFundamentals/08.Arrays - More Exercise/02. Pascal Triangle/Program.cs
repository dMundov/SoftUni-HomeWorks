using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int c = 1;
                for (int j = 0; j <= i; j++)
                {
                    System.Console.Write($"{c} ");
                    c = c * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
           Console.WriteLine();
        }
    }
}