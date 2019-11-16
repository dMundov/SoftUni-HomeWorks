using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main()
        {
            List<int> firstDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int finalSum = 0;

            while (true)
            {
                if (firstDeck[0] > secondDeck[0])
                {
                    firstDeck.Add(firstDeck[0]);
                    firstDeck.Add(secondDeck[0]);
                }
                else if (firstDeck[0] < secondDeck[0])
                {
                    secondDeck.Add(secondDeck[0]);
                    secondDeck.Add(firstDeck[0]);
                }

                firstDeck.Remove(firstDeck[0]);
                secondDeck.Remove(secondDeck[0]);

                if (firstDeck.Count == 0)
                {
                    finalSum = secondDeck.Sum();
                    Console.WriteLine($"Second player wins! Sum: {finalSum}");
                    break;
                }
                else if (secondDeck.Count == 0)
                {
                    finalSum = firstDeck.Sum();
                    Console.WriteLine($"First player wins! Sum: {finalSum}");
                    break;
                }
            }
        }
    }
}