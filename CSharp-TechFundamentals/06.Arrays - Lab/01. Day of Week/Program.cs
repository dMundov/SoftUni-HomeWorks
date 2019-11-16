using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] weekDays = {"", "Monday", "Tuesday", "Wednesday"
                                , "Thursday", "Friday", "Saturday", "Sunday"};
            if (num > 7 || num <= 0)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                for (int i = 1; i <= weekDays.Length; i++)
                {
                    if (i == num)
                    {
                        Console.WriteLine(weekDays[i]);
                    }
                }
            }

        }
    }
}
