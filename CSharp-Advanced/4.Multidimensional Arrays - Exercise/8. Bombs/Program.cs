using System;
using System.IO;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine()
                    .Split().Select(int.Parse)
                    .ToArray();

                matrix[row] = new int[input.Length];
                matrix[row] = input;
            }

            string[] bombs = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < bombs.Length; i++)
            {
                int[] bomb = bombs[i].Split(",")
                    .Select(int.Parse)
                    .ToArray();

                int bombRow = bomb[0];
                int bombCol = bomb[1];

                if (PosiitionValidation(matrix, bombRow, bombCol))
                {
                    if (matrix[bombRow][bombCol] > 0)
                    {
                        if (PosiitionValidation(matrix, bombRow - 1, bombCol - 1))
                        {
                            if (matrix[bombRow - 1][bombCol - 1] > 0)
                            {
                                matrix[bombRow - 1][bombCol - 1] -= matrix[bombRow][bombCol];
                            }
                        }
                        if (PosiitionValidation(matrix, bombRow - 1, bombCol))
                        {
                            if (matrix[bombRow - 1][bombCol] > 0)
                            {
                                matrix[bombRow - 1][bombCol] -= matrix[bombRow][bombCol];
                            }
                        }
                        if (PosiitionValidation(matrix, bombRow - 1, bombCol + 1))
                        {
                            if (matrix[bombRow - 1][bombCol + 1] > 0)
                            {
                                matrix[bombRow - 1][bombCol + 1] -= matrix[bombRow][bombCol];
                            }
                        }
                        if (PosiitionValidation(matrix, bombRow, bombCol - 1))
                        {
                            if (matrix[bombRow][bombCol - 1] > 0)
                            {
                                matrix[bombRow][bombCol - 1] -= matrix[bombRow][bombCol];
                            }
                        }
                        if (PosiitionValidation(matrix, bombRow, bombCol + 1))
                        {
                            if (matrix[bombRow][bombCol + 1] > 0)
                            {
                                matrix[bombRow][bombCol + 1] -= matrix[bombRow][bombCol];
                            }
                        }
                        if (PosiitionValidation(matrix, bombRow + 1, bombCol - 1))
                        {
                            if (matrix[bombRow + 1][bombCol - 1] > 0)
                            {
                                matrix[bombRow + 1][bombCol - 1] -= matrix[bombRow][bombCol];
                            }
                        }
                        if (PosiitionValidation(matrix, bombRow + 1, bombCol))
                        {
                            if (matrix[bombRow + 1][bombCol] > 0)
                            {
                                matrix[bombRow + 1][bombCol] -= matrix[bombRow][bombCol];
                            }
                        }
                        if (PosiitionValidation(matrix, bombRow + 1, bombCol + 1))
                        {
                            if (matrix[bombRow + 1][bombCol + 1] > 0)
                            {
                                matrix[bombRow + 1][bombCol + 1] -= matrix[bombRow][bombCol];
                            }
                        }
                        matrix[bombRow][bombCol] = 0;
                    }
                }
            }

            int aliveCells = 0;
            int sumCells = 0;

            foreach (var row in matrix)
            {
                foreach (var item in row)
                {
                    if (item > 0)
                    {
                        aliveCells++;
                        sumCells += item;
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumCells}");
            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => string.Join(" ", r))));

        }
        public static bool PosiitionValidation(int[][] matrix, int row, int col)
        {
            if (row >= 0 
                && row < matrix.Length 
                && col >= 0 
                && col < matrix[row].Length)
            {
                return true;
            }
            return false;
        }
    }
}        
