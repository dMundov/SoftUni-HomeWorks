using System;
using System.Text.RegularExpressions;

namespace _07._Match_Dates
{
    class Program
    {
        static void Main()
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string inputDate = Console.ReadLine();

            MatchCollection outPut = Regex.Matches(inputDate, pattern);

            foreach (Match date in outPut)
            {
                var day = date.Groups["day"];
                var month = date.Groups["month"];
                var year = date.Groups["year"];

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
