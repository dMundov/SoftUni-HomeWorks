using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main()
        {
            int numTimes = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numTimes; i++)
            {
                char newInChar = char.Parse(Console.ReadLine());

                sum += (int)newInChar;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
