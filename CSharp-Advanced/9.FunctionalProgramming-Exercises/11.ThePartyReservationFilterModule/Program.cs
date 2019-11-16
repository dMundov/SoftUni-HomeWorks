using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
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

            Func<string, string, bool> startsWith = (x, y) => x.StartsWith(y);
            Func<string, string, bool> endsWith = (x, y) => x.EndsWith(y);
            Func<string, string, bool> contains = (x, y) => x.Contains(y);
            Func<string, int, bool> checkLength = (x, y) => x.Length == y;

            List<string> result = new List<string>(guests);
            List<string> filtered = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Print")
                {
                    break;
                }

                string[] inputLine = input.Split(";");

                string command = inputLine[0];
                string action = inputLine[1];
                string criteria = inputLine[2];

               
                switch (action)
                {
                    case "Starts with":
                        filtered = guests.Where(x => startsWith(x, criteria)).ToList();
                        break;

                    case "Ends with":
                        filtered = guests.Where(x => endsWith(x, criteria)).ToList();
                        break;

                    case "Length":
                        filtered = guests.Where(x => checkLength(x, int.Parse(criteria))).ToList();
                        break;

                    case "Contains":
                        filtered = guests.Where(x => contains(x, criteria)).ToList();
                        break;
                }
                switch (command)
                {
                    case "Add filter":
                        result.RemoveAll(x => filtered.Contains(x));
                        break;

                    case "Remove filter":
                        result.AddRange(filtered);
                        result = result.ToList();
                        break;
                }
            }
            guests.RemoveAll(x => !result.Contains(x));
            Console.WriteLine(string.Join(" ", guests));
        }
    }
}