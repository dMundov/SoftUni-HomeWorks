using System;
using System.IO;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            void printNames(string[] names) =>
            Console.WriteLine(string.Join(Environment.NewLine, names));


            string[] inputNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            printNames(inputNames);

        }
        
    }
}
