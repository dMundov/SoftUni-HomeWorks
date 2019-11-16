using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Lumpawaroo")
                {
                    break;
                }
                else
                {
                    if (command.Contains('|'))
                    {
                        string[] dataToPut = command.Split(" | ");
                        string forceSide = dataToPut[0];
                        string forceUser = dataToPut[1];

                        if (!forceBook.ContainsKey(forceSide))
                        {
                            forceBook.Add(forceSide, new List<string>());
                        }

                        if (!forceBook.Any(x => x.Value.Contains(forceUser)))
                        {
                            forceBook[forceSide].Add(forceUser);
                        }
                    }
                    else if (command.Contains("->"))
                    {
                        string[] dataToPut = command.Split(" -> ");
                        string side = dataToPut[1];
                        string user = dataToPut[0];

                        if (!forceBook.ContainsKey(side))
                        {
                            forceBook.Add(side, new List<string>());
                        }

                        foreach (var item in forceBook)
                        {
                            if (item.Value.Contains(user))
                            {
                                item.Value.Remove(user);
                                forceBook[side].Add(user);
                                break;
                            }
                        }
                        if (!forceBook.Any(x => x.Value.Contains(user)))
                        {
                            forceBook[side].Add(user);
                        }

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
            }
            foreach (var force in forceBook.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).
                ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {force.Key}, Members: {force.Value.Count}");
                foreach (var user in force.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }

            }
        }
    }
}