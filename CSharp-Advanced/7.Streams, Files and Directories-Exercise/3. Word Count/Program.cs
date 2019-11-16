using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordsFile = @"../../../words.txt";
            string textFile = @"../../../text.txt";
            string expectedResFile = @"../../../expectedResult.txt";
            string actualResults = @"../../../actualResults.txt";


            string[] words = File.ReadAllLines(wordsFile);
            string[] text = File.ReadAllLines(textFile);

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string wordToFind = word.ToLower();
                wordsCount.Add(wordToFind, 0);
                foreach (var line in text)
                {
                    string[] currentWordsInLine = line
                        .Split(new char[] {'.',',','!','?',';'
                                            ,':','\\','-',' '})
                        .ToArray();
                    for (int i = 0; i < currentWordsInLine.Length; i++)
                    {
                        string currentWordInText = currentWordsInLine[i].ToLower();
                        if (currentWordInText == wordToFind)
                        {
                            wordsCount[word]++;
                        }
                    }
                }
            }
            if(File.Exists(actualResults))
            {
                File.Delete(actualResults);
            }
            if(File.Exists(expectedResFile))
            {
                File.Delete(expectedResFile);
            }
            foreach (var kvp in wordsCount)
            {
                string word = kvp.Key;
                int count = kvp.Value;
                File.AppendAllText(actualResults, $"{word} - {count}{Environment.NewLine}");
            }
            foreach (var kvp in wordsCount.OrderByDescending(x => x.Value))
            {
                string word = kvp.Key;
                int count = kvp.Value;
                File.AppendAllText(expectedResFile, $"{word} - {count}{Environment.NewLine}");
            }
        }
    }
}
