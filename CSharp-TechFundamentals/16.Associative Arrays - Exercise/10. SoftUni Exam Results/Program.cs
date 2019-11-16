using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> points = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] inputData = input.Split('-');
                string userName = inputData[0];

                if (inputData[1] == "banned")
                {
                    if (points.ContainsKey(userName))
                    {
                        points.Remove(userName);
                    }
                }
                else
                {
                    if (!points.ContainsKey(userName))
                    {
                        points.Add(userName, 0);
                    }

                    int currentPoints = int.Parse(inputData[2]);

                    if (points[userName] < currentPoints)
                    {
                        points[userName] = currentPoints;
                    }

                    string language = inputData[1];

                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }

                    submissions[language]++;
                }  
            }
            Console.WriteLine("Results:");
            foreach (var participant in points.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{participant.Key} | {participant.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var language in submissions.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}