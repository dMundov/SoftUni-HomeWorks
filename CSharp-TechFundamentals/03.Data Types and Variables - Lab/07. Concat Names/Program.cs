using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string secName = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.Write($"{firstName}{delimeter}{secName}");
            Console.WriteLine();

        }
    }
}
