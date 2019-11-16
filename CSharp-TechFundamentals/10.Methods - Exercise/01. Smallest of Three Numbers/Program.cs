using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {

        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSmallestNum(firstNum, secNum, thirdNum));
        }

        static int GetSmallestNum(int firstNum, int secNum, int thirdNum)
        {
            int smallestNum;
            if (firstNum < secNum && firstNum < thirdNum)
            {
                smallestNum = firstNum;
            }
            else if (firstNum > secNum && thirdNum > secNum)
            {
                smallestNum = secNum;
            }
            else
            {
                smallestNum = thirdNum;
            }

            return smallestNum;
        }
    }
}
