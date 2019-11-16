using System;
using System.IO;

namespace _02.KnightsofHonor
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            void newNames(string[] names) =>
            Console.WriteLine("Sir " + string.Join(Environment.NewLine+"Sir ", names));

            string[] inputNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            newNames(inputNames);
        }
    }
}
