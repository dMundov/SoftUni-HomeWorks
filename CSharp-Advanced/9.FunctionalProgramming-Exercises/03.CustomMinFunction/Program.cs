using System;
using System.IO;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            void printNumber(int x) => Console.WriteLine(x);

            int minNumberFunc(int[] numbers)
            {
                int minValue = int.MaxValue;

                foreach (var num in numbers)
                {
                    if (num < minValue)
                    {
                        minValue = num;
                    }
                }
                return minValue;
            }

            int[] inputNum = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int minNum = minNumberFunc(inputNum);
            printNumber(minNum);
        }
    }
}
