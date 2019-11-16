using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            PrintMatrix(num);

        }
        static void PrintMatrix(int num)
        {
            for (int column = 0; column < num; column++)
            {
                for (int row = 0; row < num-1; row++)
                {
                    Console.Write(num+ " ");
                }
                Console.WriteLine(num);
            }
        }
    }
}
