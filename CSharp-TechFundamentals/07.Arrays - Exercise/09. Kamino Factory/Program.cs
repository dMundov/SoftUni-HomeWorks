using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] bestDna = new int[lenght];
            int bestSeq = -1;
            int startIndex = -1;
            int bestDnaSum = 0;
            int bestSampleIndex = 0;

            int currentSampleIndex = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                int[] currentDna = input.Split("!",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int currentSeq = 0;
                int currentBestSeq = 0;
                int currentEndIndex = 0;

                for (int i = 0; i < currentDna.Length; i++)
                {
                    if (currentDna[i] == 1)
                    {
                        currentSeq++;
                        if (currentSeq > currentBestSeq)
                        {
                            currentEndIndex = i;
                            currentBestSeq = currentSeq;
                        }
                    }
                    else
                    {
                        currentSeq = 0;
                    }
                }

                int currentStartIndex = currentEndIndex - currentBestSeq + 1;

                bool isDnaBetter = false;
                int currentDnaSum = currentDna.Sum();

                if (currentBestSeq > bestSeq)
                {
                    isDnaBetter = true;
                }
                else if (currentBestSeq == bestSeq)
                {
                    if (currentStartIndex < startIndex)
                    {
                        isDnaBetter = true;
                    }
                    else if (currentStartIndex == startIndex)
                    {
                        if (currentDnaSum > bestDnaSum)
                        {
                            isDnaBetter = true;
                        }
                    }
                }
                currentSampleIndex++;
                if (isDnaBetter)
                {
                    bestDna = currentDna;
                    bestSeq = currentBestSeq;
                    startIndex = currentStartIndex;
                    bestDnaSum = currentDnaSum;
                    bestSampleIndex = currentSampleIndex;
                }
            }
            Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestDnaSum}.");
            Console.WriteLine(string.Join(' ', bestDna));
        }
    }
}