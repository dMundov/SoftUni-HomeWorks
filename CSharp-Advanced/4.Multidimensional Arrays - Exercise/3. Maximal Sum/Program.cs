using System;
using System.IO;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif
            int[] matrixSize = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] inputValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = inputValues[col];
                }
            }

            int sum = 0;
            int maxSum = int.MinValue;
            int[,] maxMatrixSum = new int[3, 3];

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    sum = matrix[row, col] 
                        + matrix[row, col + 1] 
                        + matrix[row, col + 2] 
                        + matrix[row + 1, col] 
                        + matrix[row + 1, col + 1] 
                        + matrix[row + 1, col + 2] 
                        + matrix[row + 2, col] 
                        + matrix[row + 2, col + 1] 
                        + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxMatrixSum[0, 0] = matrix[row, col];
                        maxMatrixSum[0, 1] = matrix[row, col + 1];
                        maxMatrixSum[0, 2] = matrix[row, col + 2];
                        maxMatrixSum[1, 0] = matrix[row + 1, col];
                        maxMatrixSum[1, 1] = matrix[row + 1, col + 1];
                        maxMatrixSum[1, 2] = matrix[row + 1, col + 2];
                        maxMatrixSum[2, 0] = matrix[row + 2, col];
                        maxMatrixSum[2, 1] = matrix[row + 2, col + 1];
                        maxMatrixSum[2, 2] = matrix[row + 2, col + 2];
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(maxMatrixSum[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}     
