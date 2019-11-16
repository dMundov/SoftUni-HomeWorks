using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                leftSum = 0;
                for (int leftIndex = i; leftIndex > 0; leftIndex--)
                {
                    int nextNum = (leftIndex - 1);
                    if (leftIndex > 0)
                    {
                        leftSum += numbers[nextNum];
                    }
                }
                rightSum = 0;
                for (int rightIndex = i; rightIndex < numbers.Length; rightIndex++)
                {
                    int nextNum = (rightIndex + 1);
                    if (rightIndex < numbers.Length - 1)
                    {
                        rightSum += numbers[nextNum];
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
//using System;
//using System.Linq;
//using System.Collections.Generic;

//namespace _06._Equal_Sum
//{
//    class Program
//    {
//        static void Main()
//        {
//            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//            List<int> index = new List<int>();

//            for (int i = 0; i < nums.Length; i++)
//                if (nums.Take(i).Sum() == nums.Skip(i + 1).Take(nums.Length - i).Sum())
//                    index.Add(i);

//            if (index.Count > 0)
//                Console.WriteLine(string.Join(", ", index));
//            else
//                Console.WriteLine("no");

//        }
//    }
//}