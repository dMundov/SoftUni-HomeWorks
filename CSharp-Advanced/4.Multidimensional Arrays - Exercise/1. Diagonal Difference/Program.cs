using System;
using System.IO;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int num = int.Parse(Console.ReadLine());

            int[,] matrix = new int[num, num];

            for (int i = 0; i < num; i++)
            {
                int[] numbers = Console.ReadLine().Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < num; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }
            long firstresult = 0;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == j)  
                    {
                        firstresult += matrix[i, j];
                    }
                }
            }
            long secondresult = 0;
            int number = 1;
            for (int i = 0; i < num; i++)
            {
                for (int j = num; j > 0;)
                {
                    
                    secondresult += matrix[i, j - number];
                    number++;
                    break;
                }
            }
            long finalResult = Math.Abs(firstresult - secondresult);
            Console.WriteLine(finalResult);
        }
    }
}
