using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> companiesAndId = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] inputData = Console.ReadLine().Split(" -> ").ToArray();

                if (inputData[0] == "End")
                {
                    break;
                }
                else
                {
                    string company = inputData[0];
                    string id = inputData[1];

                    if (!companiesAndId.ContainsKey(company))
                    {
                        companiesAndId.Add(company, new List<string>());
                        companiesAndId[company].Add(id);
                    }
                    if (!companiesAndId[company].Contains(id))
                    {
                        companiesAndId[company].Add(id);
                    }
                }
            }
            foreach (var company in companiesAndId.OrderBy(key => key.Key))
            {

                Console.WriteLine($"{company.Key}");
                foreach (var Id in company.Value)
                {
                    Console.WriteLine($"-- {Id}");
                }
            }
        }
    }
}