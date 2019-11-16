using System;

namespace _05._Messages__1
{
    class Program
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());
            int start = 1;
            

            while (start<=inputNum)
            {
                start++;
                int inputDigit = int.Parse(Console.ReadLine());

                int numOfDig = inputDigit.ToString().Length;
                int mainDigit = inputDigit % 10;
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }
                int letterIndex = (offset + numOfDig - 1);
                int index = 97 + letterIndex;
                if (inputDigit != 0)
                {
                    Console.Write((char)index);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
