using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            string firstString = input[0];
            string secondString = input[1];

            int sum = GetSum(firstString, secondString);

            Console.WriteLine(sum);
        }

        private static int GetSum(string first, string second)
        {

            char[] firstArr = first.ToCharArray();
            char[] secondArr = second.ToCharArray();
            int sum = 0;
            int minLength = Math.Min(firstArr.Length, secondArr.Length);
            int maxLength = Math.Max(firstArr.Length, secondArr.Length);

            for (int i = 0; i < minLength; i++)
            {

                sum += firstArr[i] * secondArr[i];
            }
            if (maxLength == firstArr.Length)
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    sum += firstArr[i];
                }
            }
            else
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    sum += secondArr[i];
                }
            }
            return sum;
        }
    }
}