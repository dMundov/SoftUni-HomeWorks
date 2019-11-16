using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int add(int x) => x + 1;
            int multiply(int x) => x * 2;
            int subtract(int x) => x - 1;

            void printNumbers(List<int> x) 
                             => Console.WriteLine(string.Join(" ", x));

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                else
                {
                    if (command == "add")
                    {
                        numbers = numbers.Select(add).ToList();

                    }
                    else if (command == "multiply")
                    {
                        numbers = numbers.Select(multiply).ToList();

                    }
                    else if (command == "subtract")
                    {
                        numbers = numbers.Select(subtract).ToList();

                    }
                    else if (command == "print")
                    {
                        printNumbers(numbers);

                    }
                }
            }
        }
    }
}
