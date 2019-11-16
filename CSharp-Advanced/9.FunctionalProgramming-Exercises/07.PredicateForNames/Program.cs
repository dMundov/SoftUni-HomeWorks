using System;
using System.IO;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int lenght = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            bool isLength(string name) => name.Length <= lenght;

            foreach (var name in names.Where(x => isLength(x)))
            {
                Console.WriteLine(name);
            }   
        }
    }
}
