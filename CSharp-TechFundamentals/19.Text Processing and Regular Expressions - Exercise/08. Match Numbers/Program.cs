using System;
using System.Text.RegularExpressions;

namespace _08._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = $"(^|(?<=\\s))-?\\d+(\\.\\d+)?($|(?=\\s))";
            MatchCollection numbers = Regex.Matches(input, pattern);

            foreach (Match number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}