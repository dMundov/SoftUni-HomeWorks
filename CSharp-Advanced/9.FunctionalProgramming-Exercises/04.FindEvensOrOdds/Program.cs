using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int[] bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string numType = Console.ReadLine();
            int lower = bounds[0];
            int upper = bounds[1];

            List<int> numbers = new List<int>();

            for (int i = lower; i <= upper; i++)
            {
                numbers.Add(i);
            }

            bool isEven(int num) => num % 2 == 0;
            bool isOdd(int num) => num % 2 != 0;

            Action<List<int>> printNumbers = nums
                => Console.WriteLine(string.Join(" ", nums));

            if (numType == "odd")
            {
                numbers = numbers
                    .Where(x => isOdd(x))
                    .ToList();
            }
            else
            {
                numbers = numbers
                    .Where(x => isEven(x))
                    .ToList();
            }
            printNumbers(numbers);
        }
    }
}
