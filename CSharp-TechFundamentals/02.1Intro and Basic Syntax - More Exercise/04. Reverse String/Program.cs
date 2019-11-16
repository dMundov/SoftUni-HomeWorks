using System;
using System.Linq;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string reverseInput = new string(input.Reverse().ToArray());
            {
                Console.WriteLine(reverseInput);
            }
        }
    }
}
