using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int lastNum = int.Parse(Console.ReadLine());
            int[] divisors = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            IEnumerable<int> numbers = Enumerable.Range(1, lastNum);

            bool isDevisibleFunc(int x, int y) => x % y == 0;
            bool isDivisible = true;
            List<int> result = new List<int>();

            for (int i = 1; i <= numbers.Count(); i++)
            {
                for (int j = 0; j < divisors.Length; j++)
                {
                    if (!isDevisibleFunc(i, divisors[j]))
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                {
                    result.Add(i);
                }
                isDivisible = true;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}