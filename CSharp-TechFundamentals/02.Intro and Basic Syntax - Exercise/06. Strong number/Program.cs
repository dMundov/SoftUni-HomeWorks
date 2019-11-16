using System;
using System.Linq;

namespace _06._Strong_number
{
    class Program
    {
        static void Main()
        {


            //int num = int.Parse(Console.ReadLine());

            //int newNum = num;
            //int sum = 0;
            //int factorial = 0;

            //for (int i = num; i > 0; i = i / 10)
            //{

            //    factorial = 1;
            //    for (int j = 1; j <= i % 10; j++)
            //    {
            //        factorial = factorial * j;
            //    }
            //    sum = sum + factorial;

            //}

            //if (sum == newNum)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            Console.Write("Input a number to check whether it is strong number: ");
            string nr = Console.ReadLine();
            


            int sum = 0;
            int[] digits = nr.Select(a => a - '0').ToArray();
            for (int i = 0; i < digits.Count(); i++)
            {
                int piece = Factorial(digits[i]);
                sum += piece;
            }

            if (sum == Convert.ToInt32(nr))
            {
                Console.WriteLine("{0} is a Strong number.", nr);
            }
            else
            {
                Console.WriteLine("{0} is not a Strong number.", nr);
            }

        }
        public static int Factorial(int fact)
        {
            int f = 1;
            for (int i = 1; i <= fact; i++)
            {
                f = f * i;
            }

            return f;
        }
    }
}



