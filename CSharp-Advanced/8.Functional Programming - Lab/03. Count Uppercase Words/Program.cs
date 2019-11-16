﻿using System;
using System.IO;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            Func<string,bool> capitalCheker = n => n[0] == n.ToUpper()[0];

            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(capitalCheker)
                .ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
