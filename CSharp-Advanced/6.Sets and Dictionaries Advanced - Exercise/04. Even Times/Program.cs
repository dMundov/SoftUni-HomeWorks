using System;
using System.Collections.Generic;
using System.IO;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int counter = int.Parse(Console.ReadLine());

            Dictionary<string, int> numList = new Dictionary<string, int>();

            for (int i = 0; i < counter; i++)
            {
                string input = Console.ReadLine();

                if (!numList.ContainsKey(input))
                {
                    numList.Add(input, 0);
                }
                numList[input] += 1;
            }

            foreach (var item in numList)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}