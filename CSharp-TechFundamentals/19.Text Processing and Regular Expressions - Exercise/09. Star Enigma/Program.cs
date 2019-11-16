using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09._Star_Enigma
{
    class Program
    {
        static void Main()
        {

            int number = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string inputMessage = Console.ReadLine();

                int counter = 0;
                string encryptedMessages = "";

                for (int j = 0; j < inputMessage.Length; j++)
                {
                    char currentChar = inputMessage[j];

                    if (currentChar == 's' || currentChar == 't' || currentChar == 'a' || currentChar == 'r'
                        || currentChar == 'S' || currentChar == 'T' || currentChar == 'A' || currentChar == 'R')
                    {
                        counter++;
                    }
                }
                for (int j = 0; j < inputMessage.Length; j++)
                {
                    char character = (char)(inputMessage[j] - counter);
                    encryptedMessages += character.ToString();
                }

                string pattern = $"@(?<name>[A-Za-z]+)([^@:!\\->]*):(?<population>[0-9]+)([^@:!\\->]*)!(?<type>(A|D))!([^@:!\\->]*)->(?<count>[0-9]+)";
                Match match = Regex.Match(encryptedMessages, pattern);

                if (match.Success)
                {
                    string planetName = match.Groups["name"].Value;
                    var attackType = match.Groups["type"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }
            
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

        }
    }
}

//int sumAllAtacks = attackedPlanets.Count;
//int sumAllDestroyed = destroyedPlanets.Count;