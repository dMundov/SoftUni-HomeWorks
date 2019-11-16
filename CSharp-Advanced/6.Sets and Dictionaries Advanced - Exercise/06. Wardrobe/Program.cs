using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int counter = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                string color = input[0];
                string[] items = input[1]
                    .Split(",")
                    .ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in items)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }
                    wardrobe[color][item]++;
                }
            }
            string[] lookinDress = Console.ReadLine().Split();

            foreach (var colors in wardrobe)
            {
                Console.WriteLine($"{colors.Key} clothes:");

                foreach (var item in colors.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");
                    if (lookinDress[0] == colors.Key && lookinDress[1] == item.Key)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
