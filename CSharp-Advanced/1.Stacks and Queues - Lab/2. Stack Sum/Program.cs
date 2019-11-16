using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif 
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> ourStack = new Stack<int>(input);
            while (true)
            {
                string commandInfo = Console.ReadLine().ToLower();
                if (commandInfo == "end")
                {
                    break;
                }
                else
                {
                    string[] parameters = commandInfo.Split();
                    string command = parameters[0].ToLower();
                    if (command == "add")
                    {
                        for (int i = 1; i < parameters.Length; i++)
                        {
                            ourStack.Push(int.Parse(parameters[i]));
                        }
                    }
                    else if (command == "remove")
                    {
                        int countOfNumsToRemove = int.Parse(parameters[1]);
                        if (ourStack.Count < countOfNumsToRemove)
                        {
                            continue;
                        }
                        else
                        {
                            for (int i = 0; i < countOfNumsToRemove; i++)
                            {
                                ourStack.Pop();
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {ourStack.Sum()}");
        }
    }
}