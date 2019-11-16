using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Judge
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> namesContestPoints = new Dictionary<string, Dictionary<string, int>>();
            var users = new Dictionary<string, int>();
            while (true)
            {

                string input = Console.ReadLine();

                if (input == "no more time")
                {
                    break;
                }
                else
                {
                    string[] inputData = input.Split(" -> ").ToArray();

                    string user = inputData[0];
                    string contest = inputData[1];
                    int points = int.Parse(inputData[2]);

                    if (!namesContestPoints.ContainsKey(contest))
                    {
                        namesContestPoints.Add(contest, new Dictionary<string, int>());
                        namesContestPoints[contest][user] = points;
                    }
                    else
                    {
                        if (!namesContestPoints[contest].ContainsKey(user))
                        {
                            namesContestPoints[contest][user] = points;
                        }
                        else
                        {
                            if (namesContestPoints[contest][user] < points)
                            {
                                namesContestPoints[contest][user] = points;
                            }
                        }
                    }
                }
            }
            foreach (var item in namesContestPoints)
            {

                Console.WriteLine($"{item.Key}: {item.Value.Count()} participants");
                int counter = 0;
                foreach (var name in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {name.Key} <::> {name.Value}");
                }
            }

            Console.WriteLine("Individual standings:");
            foreach (var contest in namesContestPoints)
            {
                foreach (var name in contest.Value)
                {
                    if (!users.ContainsKey(name.Key))
                    {
                        users.Add(name.Key, name.Value);
                    }
                    else
                    {
                        users[name.Key] += name.Value;
                    }
                }
            }
            int count = 0;
            foreach (var kvp in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                count++;
                Console.WriteLine($"{count}. {kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

