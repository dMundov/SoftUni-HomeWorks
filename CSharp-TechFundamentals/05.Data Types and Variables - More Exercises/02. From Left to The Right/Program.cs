using System;
using System.Linq;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();/*make array from input string 
                                                                                            by integers separete by " "*/
                long sumOfDigits = 0;
                //check wich number is greater
                if (numbers[0] > numbers[1])
                {
                    long currNumber = numbers[0];
                    while (currNumber != 0)
                    {
                        sumOfDigits += currNumber % 10;
                        currNumber /= 10;
                    }
                }
                else
                {
                    long currNumber = numbers[1];
                    while (currNumber != 0)
                    {
                        sumOfDigits += currNumber % 10;
                        currNumber /= 10;
                    }
                }
                Console.WriteLine(Math.Abs(sumOfDigits));
            }
        }
    }
}
