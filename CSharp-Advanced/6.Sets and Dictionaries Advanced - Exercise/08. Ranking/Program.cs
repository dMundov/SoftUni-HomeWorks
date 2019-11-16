using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            Dictionary<string, string> contestAndPasswords = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> students = new SortedDictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> studentsAndPoints = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of contests")
                {
                    break;
                }
                else if (input.Contains(':'))
                {
                    string[] contestAndPass = input.Split(':');
                    string contest = contestAndPass[0];
                    string password = contestAndPass[1];

                    if (!contestAndPasswords.ContainsKey(contest))
                    {
                        contestAndPasswords.Add(contest, password);
                    }
                }
            }
            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "end of submissions")
                {
                    break;
                }
                else
                {
                    string[] data = inputLine.Split("=>");

                    string contest = data[0];
                    string password = data[1];
                    string name = data[2];
                    int points = int.Parse(data[3]);

                    if (contestAndPasswords.ContainsKey(contest) && contestAndPasswords[contest] == password)
                    {
                        if (!students.ContainsKey(name))
                        {
                            students.Add(name, new Dictionary<string, int>());
                            students[name].Add(contest, points);
                        }
                        else
                        {
                            if (!students[name].ContainsKey(contest))
                            {
                                students[name].Add(contest, points);
                            }
                            if (students[name][contest] < points)
                            {
                                students[name][contest] = points;
                            }
                        }
                    }
                }
            }
            foreach (var student in students)
            {
                studentsAndPoints.Add(student.Key, 0);
                studentsAndPoints[student.Key] = student.Value.Values.Sum();
            }

            foreach (var item in studentsAndPoints.OrderByDescending(x => x.Value))
            {
                int maxPoints = studentsAndPoints.Values.Max();
                if (item.Value == maxPoints)
                {
                    Console.WriteLine($"Best candidate is {item.Key} with total {item.Value} points.");
                }
            }

            Console.WriteLine("Ranking: ");

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var contest in students[item.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}