using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] someString = Console.ReadLine().Split(" ").ToArray();

            for (int i = someString.Length - 1; i >= 0; i--)
            {
                Console.Write(someString[i] + " "); 
            }
            Console.WriteLine();
        }
    }
}
