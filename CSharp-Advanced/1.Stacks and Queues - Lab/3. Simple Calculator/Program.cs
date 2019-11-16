using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            string input = Console.ReadLine();
            string[] values = input.Split(' ');
            Stack<string> stack = new Stack<string>(values.Reverse());
            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string operand = stack.Pop();
                int second = int.Parse(stack.Pop());
                if (operand == "+")
                {

                    stack.Push((first + second).ToString());
                }
                else if (operand == "-")
                {
                    stack.Push((first - second).ToString());                    
                }

            }
            Console.WriteLine(stack.Pop());
        }
    }
}
