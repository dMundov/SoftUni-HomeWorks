using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif


            int[] comandNums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int[] inputNums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>(inputNums);
            int numToEnqueue = comandNums[0];
            int numsToDequeue = comandNums[1];
            int numsToFind = comandNums[2];

            for (int i = 0; i < numsToDequeue ; i++)
            {
                queue.Dequeue();
            }
            if(queue.Contains(numsToFind))
            {
                Console.WriteLine($"true");

            }
            else
            {
                if(queue.Count>0)
                {
                    int min = queue.Min();
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
