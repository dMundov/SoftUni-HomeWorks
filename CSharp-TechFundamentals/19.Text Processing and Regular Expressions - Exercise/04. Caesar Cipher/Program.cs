using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            string outPut = "";

            foreach (var charr in input)
            {
                int newChar = charr + 3;

                outPut += (char)newChar;
            }
            Console.WriteLine(outPut);
        }
    }
}
