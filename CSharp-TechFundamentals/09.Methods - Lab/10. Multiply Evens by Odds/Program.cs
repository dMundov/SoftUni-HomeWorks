using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main()
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(num);
            Console.WriteLine(result);
        }
        static int GetMultipleOfEvenAndOdds(int num)
        {
            int result = GetSumOfEven(num) * GetSumOfOdd(num);
            return result;
        }
        static int GetSumOfEven(int num)
        {
            int sumOfOdds = 0;

            while (num != 0)
            {
                int nextNum = num % 10;

                if (nextNum % 2 == 1)
                {
                    sumOfOdds += nextNum;
                }
                num -= nextNum;
                num /= 10;

            }
            return sumOfOdds;
        }
        static int GetSumOfOdd(int num)
        {
            int sumOfEvens = 0;
            while (num != 0)
            {
                int nextNum = num % 10;

                if (nextNum % 2 == 0)
                {
                    sumOfEvens += nextNum;
                }
                num -= nextNum;
                num /= 10;
            }
            return sumOfEvens;
        }
    }
}