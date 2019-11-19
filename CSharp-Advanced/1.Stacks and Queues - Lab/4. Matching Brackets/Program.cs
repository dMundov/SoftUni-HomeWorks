using System;
using System.Collections.Generic;
using System.IO;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
                
            Stack<int> ourStack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    ourStack.Push(i);
                }
                else if (input[i] ==')')
                {
                    int openBrIndex = ourStack.Pop();

                    Console.WriteLine(input.Substring(openBrIndex,i-openBrIndex+1));
                }
            }
        }
    }
}
