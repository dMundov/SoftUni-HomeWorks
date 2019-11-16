using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            int count = int.Parse(Console.ReadLine());

            HashSet<string> finalTable = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                foreach (string item in input)
                {
                    finalTable.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", finalTable.OrderBy(x => x)));
        }
    }
}