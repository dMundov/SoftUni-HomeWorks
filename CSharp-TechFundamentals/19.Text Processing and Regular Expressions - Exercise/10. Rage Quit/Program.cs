//using System;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace _10._Rage_Quit
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            StringBuilder newSymbols = new StringBuilder();
//            string patten = @"([^0-9]+[0-9]+)";
//            var matches = Regex.Matches(input, patten);

//            foreach (var match in matches)
//            {
//                string strMatch = match.ToString();
//                string symbolsPattern = @"([^0-9]+)";
//                var symbolReg = Regex.Match(strMatch, symbolsPattern);
//                string symbols = symbolReg.Groups[1].Value.ToString();
//                symbols = symbols.ToUpper();
//                string patternNumber = @"([0-9]+)";
//                var regNumber = Regex.Match(strMatch, patternNumber);
//                int number = int.Parse(regNumber.ToString());
//                for (int i = 0; i < number; i++)
//                {
//                    newSymbols.Append(symbols);
//                }
//            }
//            string uniqueSymbol = new String(newSymbols.ToString().Distinct().ToArray());
//            Console.WriteLine($"Unique symbols used: {uniqueSymbol.Length}\n{newSymbols.ToString()}"); 
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04_Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            var uniqueSymbols = new Dictionary<char, int>();
            string pattern = @"([^\d]+)(\d+)";
            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder newSumbols = new StringBuilder();
            foreach (Match item in matches)
            {
                string characters = item.Groups[1].ToString();
                int repeatString = int.Parse(item.Groups[2].ToString());
                if (repeatString == 0)
                    continue;
                for (int i = 0; i < characters.Length; i++)
                {
                    var currentElement = characters[i];
                    if (!uniqueSymbols.ContainsKey(currentElement))
                    {
                        uniqueSymbols[currentElement] = 1;
                    }
                }
                for (int i = 0; i < repeatString; i++)
                {
                    newSumbols.Append(characters);
                }
            }
            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Keys.Count}\n{newSumbols.ToString()}");

        }
    }
}