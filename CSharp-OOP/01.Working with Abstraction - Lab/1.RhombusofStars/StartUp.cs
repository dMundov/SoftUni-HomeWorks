﻿namespace _1.RhombusofStars
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int starCount = 1; starCount <= size; starCount++)
            {
                PrintRow(size, starCount);
            }

            for (int starCount = size - 1; starCount >= 1; starCount--)
            {
                PrintRow(size, starCount);
            }

        }
        static void PrintRow(int figureSize, int starCount)
        {
            for (int i = 0; i < figureSize - starCount; i++)
            {
                Console.Write(" ");
            }
            for (int col = 1; col < starCount; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("*");
        }
    }
}
