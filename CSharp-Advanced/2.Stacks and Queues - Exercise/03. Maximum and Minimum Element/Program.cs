using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int numberOfoperations = int.Parse(Console.ReadLine());

            Stack<int> ourNumsStack = new Stack<int>();

            for (int i = 0; i < numberOfoperations; i++)
            {
                int[] commands = Console.ReadLine()
                    .Split(" ").Select(int.Parse).ToArray();

                int operation = commands[0];
                if (operation == 1)
                {
                    int numToPush = commands[1];
                    ourNumsStack.Push(numToPush);
                }
                if (operation == 2 && ourNumsStack.Count > 0)
                {
                    ourNumsStack.Pop();
                }
                if (operation == 3 && ourNumsStack.Count > 0)
                {

                    int max = ourNumsStack.Max();
                    Console.WriteLine(max);
                }
                if (operation == 4 && ourNumsStack.Count > 0)
                {
                    int min = ourNumsStack.Min();
                    Console.WriteLine(min);
                }

            }
            Console.WriteLine(string.Join(", ", ourNumsStack));
        }
    }
}
