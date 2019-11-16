using System;
using System.Collections.Generic;
using System.IO;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            var parantheses = Console.ReadLine()
                .Trim()
                .ToCharArray();

            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> parenthesesPair = new Dictionary<char, char>
            {
                ['{'] = '}',
                ['['] = ']',
                ['('] = ')'
            };

            if (parantheses.Length % 2 != 0 || parantheses.Length == 0)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (var ch in parantheses)
            {
                
                if (parenthesesPair.ContainsKey(ch))
                {
                    stack.Push(ch);
                }
                else
                {
                    var openParantheses = stack.Pop();
                    if (parenthesesPair[openParantheses] != ch)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}        