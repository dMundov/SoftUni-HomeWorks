using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _08._Match_Phone_Number
{
    class Program
    {
        static void Main()
        {
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
            string input = Console.ReadLine();

            var outPutNumber = Regex.Matches(input, pattern);

            List<string> numbers = new List<string>();

            foreach (var match in outPutNumber)
            {
                numbers.Add(match.ToString());
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
