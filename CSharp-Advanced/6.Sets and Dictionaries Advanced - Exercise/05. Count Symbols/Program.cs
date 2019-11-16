using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            string input = Console.ReadLine();

            Dictionary<char, int> symbolsList = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!symbolsList.ContainsKey(input[i]))
                {
                    symbolsList.Add(input[i], 0);
                    symbolsList[input[i]] += 1;
                }
                else
                {
                    symbolsList[input[i]] += 1;
                }
            }
            foreach (var item in symbolsList.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}
