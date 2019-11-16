using System;
using System.IO;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int[] matrixSize = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] matrixValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = matrixValues[col];
                }
            }
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }
                else
                {
                    string[] input = command.Split();

                    if (input[0] != "swap" || input.Length != 5)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        int firstNumToSwapRow = int.Parse(input[1]);
                        int firstNumToSwapCol = int.Parse(input[2]);
                        int secondNumToSwapRow = int.Parse(input[3]);
                        int secondNumToSwapCol = int.Parse(input[4]);

                        if (firstNumToSwapCol < 0 
                            || firstNumToSwapCol > matrix.GetLength(1) 
                            || firstNumToSwapRow < 0 
                            || firstNumToSwapRow > matrix.GetLength(0) 
                            || secondNumToSwapRow < 0 
                            || secondNumToSwapRow > matrix.GetLength(0) 
                            || secondNumToSwapCol < 0 
                            || secondNumToSwapCol > matrix.GetLength(1))
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            string temp = matrix[firstNumToSwapRow, firstNumToSwapCol];
                            matrix[firstNumToSwapRow, firstNumToSwapCol] = matrix[secondNumToSwapRow, secondNumToSwapCol];
                            matrix[secondNumToSwapRow, secondNumToSwapCol] = temp;

                            for (int row = 0; row < rows; row++)
                            {
                                for (int col = 0; col < cols; col++)
                                {
                                    Console.Write(matrix[row, col] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}   