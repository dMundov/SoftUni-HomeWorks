using System;
using System.Collections.Generic;
using System.IO;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int num = int.Parse(Console.ReadLine());

            Stack<string> prCommands = new Stack<string>();

            string text = string.Empty;

            for (int i = 0; i < num; i++)
            {
                string[] commands = Console.ReadLine()
                                .Split(" ", StringSplitOptions
                                .RemoveEmptyEntries);
                switch (commands[0])
                {
                    case "1":
                        prCommands.Push(text);
                        text += commands[1];
                        break;

                    case "2":
                        prCommands.Push(text);
                        text = text.Substring(0, text.Length - int.Parse(commands[1]));
                        break;

                    case "3":
                        Console.WriteLine(text[int.Parse(commands[1]) - 1]);
                        break;

                    case "4":
                        text = prCommands.Pop();
                        break;
                }
            }
        }
    }
}      
