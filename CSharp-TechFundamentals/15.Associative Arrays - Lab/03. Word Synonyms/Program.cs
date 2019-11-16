using System;
using System.Linq;
using System.Collections.Generic;   

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < num; i++)
            {
                string word = Console.ReadLine();
                string secWord = Console.ReadLine();

                if(!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                    words[word].Add(secWord);
                }
                else
                {
                    words[word].Add(secWord);
                }
            }
            foreach (var kVp in words)
            {
                string word = kVp.Key;
                List<string> synonim = kVp.Value;
                Console.WriteLine($"{word} - {string.Join(", ",synonim)}");
            }
        }
    }
}
