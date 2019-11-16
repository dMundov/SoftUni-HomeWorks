using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestPasswords = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> nameAndContesstWithPoints = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                string[] inputData = new string[2];

                if (input == "end of contests")
                {
                    break;
                }
                else
                {
                    inputData = input.Split(":").ToArray();

                    string contest = inputData[0];
                    string pass = inputData[1];

                    if(!contestPasswords.ContainsKey(contest))
                    {
                        contestPasswords.Add(contest, pass);
                    }
                }
            }
            string inputCollection = "";
            string[] separator = { "=>" };
            while (( inputCollection = Console.ReadLine()) != "end of submissions")
            {
                string[] str2 = inputCollection.Split(separator, StringSplitOptions.None);
                string contestFromCollection = str2[0];
                string passwordFromCollection = str2[1];
                string nameCollection = str2[2];
                int pointFromCollection = int.Parse(str2[3]);
                if (contestPasswords.ContainsKey(contestFromCollection)
                    && contestPasswords.ContainsValue(passwordFromCollection))
                {
                    if (!nameAndContesstWithPoints.ContainsKey(nameCollection))
                    {
                        nameAndContesstWithPoints.Add(nameCollection, new Dictionary<string, int>());
                        nameAndContesstWithPoints[nameCollection].Add(contestFromCollection, pointFromCollection);
                    }
                    if (nameAndContesstWithPoints[nameCollection].ContainsKey(contestFromCollection))
                    {
                        if (nameAndContesstWithPoints[nameCollection][contestFromCollection] < pointFromCollection)
                        {
                            nameAndContesstWithPoints[nameCollection][contestFromCollection] = pointFromCollection;
                        }
                    }
                    else
                    {
                        nameAndContesstWithPoints[nameCollection].Add(contestFromCollection, pointFromCollection);
                    }
                }

            }
            Dictionary<string, int> userTotalPoints = new Dictionary<string, int>();
            foreach (var kvp in nameAndContesstWithPoints)
            {
                userTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }
            string bestUser = userTotalPoints
                .Keys
                .Max();
            int bestPoints = userTotalPoints
                .Values
                .Max();

            foreach (var kvp in userTotalPoints)
            {
                if (kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

                }
            }
            Console.WriteLine("Ranking:");
            foreach (var name in nameAndContesstWithPoints)
            {
                Dictionary<string, int> dict = name.Value;
                dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine($"{name.Key}");
                foreach (var kvp in dict)
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }

            }
        }
    }
}
