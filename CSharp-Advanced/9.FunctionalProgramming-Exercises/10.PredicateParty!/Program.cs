using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            List<string> guests = Console.ReadLine()
                                .Split()
                                .ToList();

            bool filter(string guest, string action, string criteria) =>
                 action == "EndsWith" ?
                 guest.EndsWith(criteria) : action == "StartsWith" ?
                 guest.StartsWith(criteria) : guest.Length == int.Parse(criteria);


            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "Party!")
                {
                    break;
                }

                string command = input[0];
                string action = input[1];
                string criteria = input[2];

                if (command == "Remove")
                {
                    guests = guests.Where(x => !filter(x, action, criteria)).ToList();
                }
                else if (command == "Double")
                {
                    List<string> duplicate = guests.Where(x => filter(x, action, criteria)).ToList();

                    foreach (var guest in duplicate)
                    {
                        int index = guests.IndexOf(guest) + 1;

                        guests.Insert(index, guest);
                    }
                }
            }
            if (guests.Any())
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
