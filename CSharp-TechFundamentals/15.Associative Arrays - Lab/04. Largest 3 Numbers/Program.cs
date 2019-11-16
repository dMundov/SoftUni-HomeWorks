using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] sorted = numbers.OrderByDescending(n => n).ToArray();
            if (sorted.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {

                    {
                        Console.Write(sorted[i] + " ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < sorted.Length; i++)
                {
                    Console.Write(sorted[i] + " ");
                }
            }
        }
    }
}
