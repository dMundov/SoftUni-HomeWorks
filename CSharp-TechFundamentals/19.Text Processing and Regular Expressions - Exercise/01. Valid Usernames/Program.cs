using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main()
        {
            string[] inputNames = Console.ReadLine().Split(", ");
            List<string> validUserNames = new List<string>();

            for (int i = 0; i < inputNames.Length; i++)
            {
                string currentUserName = inputNames[i];
                if (currentUserName.Length >= 3 && currentUserName.Length <= 16)
                {
                    bool validUsernames = ValidNames(currentUserName);
                    if (validUsernames == true)
                    {
                        validUserNames.Add(currentUserName);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, validUserNames));
        }

        private static bool ValidNames(string user)
        {
            foreach (var symbol in user)
            {
                if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
