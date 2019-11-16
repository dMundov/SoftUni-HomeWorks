using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courseAndUsers = new Dictionary<string,List<string>>();

            string course = "";
            string studentName = "";
            while (true)
            {
                string[] inputData = Console.ReadLine().Split(" : ").ToArray();

                if(inputData[0]== "end")
                {
                    break;
                }
                else
                {
                   course = inputData[0];
                   studentName = inputData[1];

                    if(!courseAndUsers.ContainsKey(course))
                    {
                        courseAndUsers.Add(course, new List<string>());
                        courseAndUsers[course].Add(studentName);

                    }
                    else
                    {
                        courseAndUsers[course].Add(studentName);
                    }
                }
            }
            foreach (var kVp in courseAndUsers.OrderByDescending(x => x.Value.Count))
            {
                
                Console.WriteLine($"{kVp.Key}: {kVp.Value.Count}");

                foreach (var name in kVp.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
