// way to solve with array.
/*
using system;

namespace _03._recursive_fibonacci
{
    class program
    {
        static void main()
        {
            int num = int.parse(console.readline());

            int[] fibnum = new int[49];
            fibnum[0] = 1;
            fibnum[1] = 1;
            for (int i = 2; i < num; i++)
            {
                fibnum[i] = fibnum[i - 2] + fibnum[i - 1];
            }
            console.writeline(fibnum[num - 1]);
        }
    }
}
*/

//second way to solve with Recursive! -->
using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FibunacciNum(number - 1));

        }
        static int FibunacciNum(int num)
        {
            if (num <= 1)
                return 1;
            return FibunacciNum(num - 1) + FibunacciNum(num - 2);
        }
    }
}
