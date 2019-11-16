using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int[] nums = new int[num];

            for (int i = 0; i < num; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                nums[i] += newNum;
            }
            for (int i = nums.Length-1; i >=0; i--)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
        }
    }
}
