using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            List<int> numbers = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

            var num = int.Parse(Console.ReadLine());

            bool isDivisible(int x) => x % num != 0;
            Func<List<int>, List<int>> reverse = x =>
            {
                var tempList = new List<int>();

                for (int i = x.Count - 1; i >= 0; i--)
                {
                    tempList.Add(x[i]);
                }
                return x = tempList.ToList();
            };

            Console.WriteLine(string.Join(" ", reverse(numbers).Where(x => isDivisible(x))));
        }
    }
}