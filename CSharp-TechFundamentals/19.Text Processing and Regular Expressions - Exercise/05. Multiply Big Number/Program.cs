using System;
using System.Collections.Generic;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main()
        {

            string number = Console.ReadLine().TrimStart(new char[] { '0' });
            int multiplyNum = int.Parse(Console.ReadLine());
            if (multiplyNum == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int reminder = 0;
            int currentMultiplication = 0;
            List<int> result = new List<int>();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentDigit = number[i] - '0';
                currentMultiplication = currentDigit * multiplyNum;
                currentMultiplication += reminder;
                result.Add(currentMultiplication % 10);
                reminder = currentMultiplication / 10;
            }
            if (reminder > 0)
            {
                result.Add(reminder);
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}      
