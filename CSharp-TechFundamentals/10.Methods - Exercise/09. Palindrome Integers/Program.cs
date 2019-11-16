using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main()
        {
            string input = string.Empty;

            PalindromeChecker(input);
        }

        private static void PalindromeChecker(string input)
        {
            string reversedInput = string.Empty;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedInput += input[i];
                }
                if (reversedInput != input)
                {
                    Console.WriteLine("false");
                }
                else if (reversedInput == input)
                {
                    Console.WriteLine("true");
                }
                reversedInput = string.Empty;
            }
        }
    }
}