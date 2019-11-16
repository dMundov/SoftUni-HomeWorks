using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            Dictionary<string, List<string>> vloggerAndFollowers = new Dictionary<string, List<string>>();
            Dictionary<string, int[]> vloggerAndFollowing = new Dictionary<string, int[]>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }
                string[] info = input.Split();
                string name = info[0];

                if (input.Contains("joined"))
                {
                    if (!vloggerAndFollowers.ContainsKey(name))
                    {
                        vloggerAndFollowers.Add(name, new List<string>());
                        vloggerAndFollowing.Add(name, new int[2]);
                    }
                }
                else if (input.Contains("followed"))
                {
                    string followedName = info[2];
                    if (vloggerAndFollowers.ContainsKey(name) && vloggerAndFollowers.ContainsKey(followedName)
                        && name != followedName && !vloggerAndFollowers[followedName].Contains(name))
                    {
                        vloggerAndFollowers[followedName].Add(name);
                        vloggerAndFollowing[followedName][0]++;
                        vloggerAndFollowing[name][1]++;
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of { vloggerAndFollowers.Count} vloggers in its logs.");

            int counter = 1;

            foreach (var item in vloggerAndFollowing.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Value[1]))
            {
                Console.WriteLine($"{counter}. {item.Key} : {item.Value[0]} followers, {item.Value[1]} following");

                if (counter == 1)
                {
                    var mostFollowed = vloggerAndFollowers.First(x => x.Key == item.Key);

                    foreach (var first in mostFollowed.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {first}");
                    }
                }
                counter++;
            }
        }
    }
}