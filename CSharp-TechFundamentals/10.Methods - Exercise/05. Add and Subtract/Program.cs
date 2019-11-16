using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = Sum(firstNum, secNum);
            Subtract(sum,thirdNum);
        }
        static int Sum(int firstNum, int secNum)
        {
            int result = firstNum+secNum;
            return result;
        }
        static void Subtract(int result, int thirdNum)
        {
            int sub = result-thirdNum;

            Console.WriteLine(sub);
        }
    }
}
