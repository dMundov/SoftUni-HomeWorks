using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {


        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int[] lengths = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();

            HashSet<string> firstSet = new HashSet<string>();
            HashSet<string> secondSet = new HashSet<string>();
            HashSet<string> finalSet = new HashSet<string>();

            for (int i = 0; i < lengths[0] + lengths[1]; i++)
            {
                string input = Console.ReadLine();

                if (i < lengths[0])
                {

                    firstSet.Add(input);
                }
                else
                {
                    secondSet.Add(input);
                }
            }

            HashSet<string> minHash = new HashSet<string>();
            HashSet<string> maxHash = new HashSet<string>();

            if (firstSet.Count < secondSet.Count)
            {
                minHash = firstSet;
                maxHash = secondSet;
            }
            else
            {
                minHash = secondSet;
                maxHash = firstSet;
            }
            foreach (var item in minHash)
            {
                if (maxHash.Contains(item))
                {
                    finalSet.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", finalSet));
        }
    }
}
