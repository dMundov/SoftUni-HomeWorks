using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int number = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            Console.WriteLine(names.FirstOrDefault(name => 
                              name.ToCharArray().Sum(x => x) >= number));
        }
    }
}