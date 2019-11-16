using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            int[] inputbottles = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] inputcups = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            Stack<int> bottles = new Stack<int>(inputcups);
            Queue<int> cups = new Queue<int>(inputbottles);

            int wastedWater = 0;

            while (bottles.Any() && cups.Any())
            {
                if (cups.Peek() > bottles.Peek())
                {
                    int remaining = 0;
                    int currentCup = cups.Dequeue();
                    while (currentCup > 0)
                    {
                        int currentBottle = bottles.Pop();
                        currentCup -= currentBottle;
                        remaining = currentCup * -1;
                    }
                    wastedWater += remaining;
                }
                else
                {
                    int currentBottle = bottles.Pop();
                    int currentCup = cups.Dequeue();
                    wastedWater += currentBottle - currentCup;
                }
            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles.ToArray())}");
            }
            else if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups.ToArray())}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}