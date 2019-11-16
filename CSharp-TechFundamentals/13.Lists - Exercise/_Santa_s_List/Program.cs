using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Santa_s_List
{
    class Program
    {
        static void Main()
        {
            List<string> kids = Console.ReadLine().Split('&').ToList();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Finished!")
                {
                    break;
                }
                List<string> commandParts = command.Split(" ").ToList();
                if (commandParts[0] == "Bad")
                {
                    string kidName = commandParts[1];
                    if (!kids.Contains(kidName))
                    {
                        kids.Insert(0, kidName);
                    }
                }
                if (commandParts[0] == "Good")
                {
                    string kidName = commandParts[1];
                    if (kids.Contains(kidName))
                    {
                        kids.Remove(kidName);
                    }
                }
                if (commandParts[0] == "Rename")
                {
                    string kidName = commandParts[1];
                    string newKidName = commandParts[2];
                    if (kids.Contains(kidName))
                    {
                        var indexOfKidName = kids.IndexOf(kidName);
                        kids[indexOfKidName] = newKidName;
                    }
                }
                if (commandParts[0] == "Rearrange")
                {
                    string kidName = commandParts[1];
                    if (kids.Contains(kidName))
                    {
                        kids.Remove(kidName);
                        kids.Add(kidName);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", kids));
        }
    }
}