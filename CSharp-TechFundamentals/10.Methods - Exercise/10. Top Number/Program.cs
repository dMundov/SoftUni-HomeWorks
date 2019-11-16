using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            TopNumber(number);
        }
        static void TopNumber(int number)
        {
            int num = 0;
            int sum = 0;
            int counter = 0;
            for (int i = 1; i <= number; i++)
            {
                num = i;
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;

                }
                string nums = i.ToString();
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] % 2 != 0)
                    {
                        counter++;
                    }
                }
                if (sum % 8 == 0 && counter > 0)
                {
                    Console.WriteLine(i);
                }
                sum = 0;
                counter = 0;
            }
        }
    }
}
