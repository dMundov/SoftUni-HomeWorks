using System;
using System.Text.RegularExpressions;

namespace _06._Match_Full_Name
{
    class Program
    {
        static void Main()
        {
            string pattern = @"\b((([A-Z]{1}[a-z]+) ([A-Z]{1}[a-z]+))\b)";

            string input = Console.ReadLine();

            var outPut = Regex.Matches(input, pattern);

            foreach (var match in outPut)
            {

                Console.Write(match+" ");
            }
            Console.WriteLine();
        }
    }
}
