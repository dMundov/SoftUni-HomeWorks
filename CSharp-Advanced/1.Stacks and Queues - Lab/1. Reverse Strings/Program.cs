using System;
using System.Collections.Generic;
using System.IO;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            string input = Console.ReadLine();
            Stack<char> ourStack = new Stack<char>();

            foreach (var ch in input)
            {
                ourStack.Push(ch);
            }
            while (ourStack.Count != 0)
            {
                Console.Write(ourStack.Pop());
            }
            Console.WriteLine();
        }
    }
}
