using System;
using System.IO;
using System.Linq;

namespace _6._Bomb_the_Basement
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
            int[] bombArea = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];
            int[,] matrix = new int[rows, cols];
            int bombRow = bombArea[0];
            int bombCol = bombArea[1];
            int bombRadius = bombArea[2];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - bombRow, 2) 
                                 + Math.Pow(col - bombCol, 2));

                    if (distance <= bombRadius)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }

            int[][] tempMatrix = new int[cols][];

            for (int row = 0; row < cols; row++)
            {
                tempMatrix[row] = new int[rows];

                for (int col = 0; col < rows; col++)
                {
                    tempMatrix[row][col] = matrix[col, row];
                }

                tempMatrix[row] = tempMatrix[row]
                    .OrderByDescending(x => x)
                    .ToArray();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = tempMatrix[col][row];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}