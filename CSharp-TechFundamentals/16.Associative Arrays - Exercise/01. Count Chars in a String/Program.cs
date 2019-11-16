using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main()
        {
            List<string> first = Console.ReadLine()
                                 .Split()
                                 .ToList();

            string allWordsAsOne = "";
            if (first.Count > 1)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    allWordsAsOne += first[i];
                }
            }
            else
            {
                allWordsAsOne += first[0];
            }

            char[] allWordChars = allWordsAsOne.ToCharArray();
            Dictionary<char, int> numberChar = new Dictionary<char, int>();

            foreach (var kVp in allWordChars)
            {
                if (!numberChar.ContainsKey(kVp))
                {
                    numberChar[kVp] = 0;
                }
                numberChar[kVp]++;
            }
            foreach (var kVp in numberChar)
            {
                Console.WriteLine($"{kVp.Key} -> {kVp.Value}");
            }
        }
    }
}