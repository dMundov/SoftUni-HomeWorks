using System;
using System.IO;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"C:\Users\dMundov\Desktop\input.txt"));
#endif

            int boardSize = int.Parse(Console.ReadLine());

            char[][] matrix = new char[boardSize][];

            for (int row = 0; row < boardSize; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                matrix[row] = new char[input.Length];
                matrix[row] = input;
            }

            int counter = 0;
            int maxCounter = 0;
            int maxRow = -1;
            int maxCol = -1;
            int counterRemoved = 0;

            while (true)
            {
                for (int row = 0; row < boardSize; row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (matrix[row][col] == 'K')
                        {
                            if (GetPosiition(matrix, row - 2, col - 1))
                            {
                                if (matrix[row - 2][col - 1] == 'K')
                                {
                                    counter++;
                                }
                            }
                            if (GetPosiition(matrix, row - 2, col + 1))
                            {
                                if (matrix[row - 2][col + 1] == 'K')
                                {
                                    counter++;
                                }
                            }
                            if (GetPosiition(matrix, row - 1, col + 2))
                            {
                                if (matrix[row - 1][col + 2] == 'K')
                                {
                                    counter++;
                                }
                            }
                            if (GetPosiition(matrix, row - 1, col - 2))
                            {
                                if (matrix[row - 1][col - 2] == 'K')
                                {
                                    counter++;
                                }
                            }
                            if (GetPosiition(matrix, row + 1, col - 2))
                            {
                                if (matrix[row + 1][col - 2] == 'K')
                                {
                                    counter++;
                                }
                            }
                            if (GetPosiition(matrix, row + 1, col + 2))
                            {
                                if (matrix[row + 1][col + 2] == 'K')
                                {
                                    counter++;
                                }
                            }
                            if (GetPosiition(matrix, row + 2, col - 1))
                            {
                                if (matrix[row + 2][col - 1] == 'K')
                                {
                                    counter++;
                                }
                            }
                            if (GetPosiition(matrix, row + 2, col + 1))
                            {
                                if (matrix[row + 2][col + 1] == 'K')
                                {
                                    counter++;
                                }
                            }

                        }
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            maxRow = row;
                            maxCol = col;
                        }
                        counter = 0;
                    }
                }
                if (maxCounter != 0)
                {
                    counterRemoved++;
                    matrix[maxRow][maxCol] = '0';
                    maxCounter = 0;
                }
                else
                {
                    Console.WriteLine(counterRemoved);
                    return;
                }
            }
        }
        public static bool GetPosiition(char[][] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length)
            {
                return true;
            }
            return false;
        }
    }
}