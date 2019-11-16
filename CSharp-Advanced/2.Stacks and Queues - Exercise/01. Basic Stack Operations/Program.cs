using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            int[] comandsNums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] inputNums = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();

            Stack<int> ourStack = new Stack<int>(inputNums);

            int numToPush = comandsNums[0];
            int numsToPop = comandsNums[1];
            int numsToFind = comandsNums[2];

            for (int i = 0; i < numsToPop; i++)
            {
                ourStack.Pop();
            }
            if(ourStack.Contains(numsToFind))
            {
                Console.WriteLine($"true");
            }
            else
            {
                if (ourStack.Count > 0)
                {
                    int min = ourStack.Min();
                    Console.WriteLine(min);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
