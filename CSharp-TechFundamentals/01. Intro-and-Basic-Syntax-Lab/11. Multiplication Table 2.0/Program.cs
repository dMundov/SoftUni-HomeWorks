using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int startNum = int.Parse(Console.ReadLine());
            int sum = 0;
            if (startNum > 10)
            {
                Console.WriteLine($"{num} X {startNum} = {num * startNum}");
            }
            else
            {
                for (int i = startNum; i <= 10; i++)
                {
                    sum = num * i;
                    Console.WriteLine($"{num} X {i} = {sum}");
                } 
            }
        }
    }
}