using System;
using System.IO;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main()
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int[] matrixSize = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToArray();

            string snakeString = Console.ReadLine();

            int rows = matrixSize[0];
            int cols = matrixSize[1];
            char[,] matrix = new char[rows, cols];
            int charCounter = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (charCounter == snakeString.Length)
                    {
                        charCounter = 0;
                    }

                    matrix[row, col] = snakeString[charCounter];
                    charCounter++;
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}       