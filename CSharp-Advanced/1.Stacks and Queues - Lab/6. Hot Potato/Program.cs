using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _6_.Hot_Potato 
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif


            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int number = int.Parse(Console.ReadLine());

            Queue<string> queueNames = new Queue<string>(names);

            while (queueNames.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queueNames.Enqueue(queueNames.Dequeue());
                }
                Console.WriteLine($"Removed {queueNames.Dequeue()}");
            }
            Console.WriteLine($"Last is {queueNames.Dequeue()}");

        }
    }
}