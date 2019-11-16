using System;
using System.Text.RegularExpressions;

namespace _12._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            double totalIncomeForDay = 0;

            while (true)
            {
                string productLine = Console.ReadLine();

                if (productLine == "end of shift")
                {
                    break;
                }

                if (Regex.IsMatch(productLine, pattern))
                {
                    Match match = Regex.Match(productLine, pattern);
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double money = price * count;
                    Console.WriteLine($"{customer}: {product} - {money:F2}");
                    totalIncomeForDay += money;
                }
            }
            Console.WriteLine($"Total income: {totalIncomeForDay:f2} ");
        }
    }
}