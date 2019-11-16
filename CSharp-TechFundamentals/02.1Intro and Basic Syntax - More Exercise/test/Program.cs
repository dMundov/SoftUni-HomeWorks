using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = Console.ReadLine();

            string reversedString = string.Empty;

            for (int i = someString.Length-1; i >=0 ; i--)
            {
                reversedString += someString[i];
            }
            reversedString.ToString();
            Console.WriteLine(reversedString);
        }
    }
}
