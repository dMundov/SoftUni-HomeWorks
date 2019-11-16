using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counters = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordsToLowerCases = word.ToLower();
                if (counters.ContainsKey(wordsToLowerCases))
                {
                    counters[wordsToLowerCases]++;
                }
                else
                {
                    counters.Add(wordsToLowerCases, 1);
                }
            }
            foreach (var counter in counters)
            {
                if (counter.Value % 2 != 0)
                {
                    Console.Write(counter.Key + " ");
                }
            }
        }
    }
}
