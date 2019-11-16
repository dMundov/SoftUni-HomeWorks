using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5.FilterbyAge
{
    class Program

    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int num = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = input[0];
                int currentAge = int.Parse(input[1]);

                if (!people.ContainsKey(name))
                {
                    people.Add(name, currentAge);
                }
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine().Split();
            people.Where(d => condition == "older" ? d.Value >= age : d.Value < age)
                 .ToList()
                 .ForEach(d => Print(d, format));
        }

        static void Print(KeyValuePair<string, int> name, string[] format)
        {
            if (format.Length == 2)
            {
                Console.WriteLine($"{name.Key} - {name.Value}");
            }
            else
            {
                Console.WriteLine(format[0] == "name" ? $"{name.Key}" : $"{name.Value}");
            }
        }
    }
}