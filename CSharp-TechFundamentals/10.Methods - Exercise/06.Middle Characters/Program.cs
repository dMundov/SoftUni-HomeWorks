using System;

namespace _06.Middle_Characters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            PrintMiddleChar(input);
        }
        static void PrintMiddleChar(string input)
        {
            char[] charsFromString = input.ToCharArray();
            int charsCounter = 0;
            int center = 0;
            for (int i = 0; i < input.Length; i++)
            {
                charsCounter++;
            }
            if(charsCounter%2==0)
            {
                center = input.Length / 2;
                Console.Write($"{charsFromString[center-1]}{charsFromString[center]}");
            }
            else
            {
                center = (input.Length + 1) / 2;
                Console.WriteLine(charsFromString[center-1]);
            }
        }
    }
}
