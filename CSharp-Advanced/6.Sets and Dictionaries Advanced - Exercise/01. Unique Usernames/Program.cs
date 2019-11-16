using System;
using System.Collections.Generic;
using System.IO;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int number = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                
                if(!names.Contains(name))
                {
                    names.Add(name);
                }
                else
                {
                    continue;
                }
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
