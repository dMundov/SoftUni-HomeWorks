using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            List<int> inputNumbers = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToList();

            bool isEven(int num) => num % 2 == 0;
            bool isOdd(int num) => num % 2 != 0;
            inputNumbers.Sort();
            Console.WriteLine(string.Join(" ", inputNumbers.OrderBy(isOdd).ThenBy(isEven)));
        }
    }
}
