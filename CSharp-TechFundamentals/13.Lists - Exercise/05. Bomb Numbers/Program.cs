using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> listNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> bombAndPower = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            for (int position = 0; position < listNumbers.Count; position++)
            {
                if (listNumbers[position] == bombAndPower[0])
                {
                    for (int posToRemove = 1; posToRemove <= bombAndPower[1]; posToRemove++)
                    {
                        if (position - posToRemove < 0)
                        {
                            break;
                        }
                        else
                        {
                            listNumbers[position - posToRemove] = 0;
                        }
                    }
                    for (int j = 1; j <= bombAndPower[1]; j++)
                    {
                        if (position + j > listNumbers.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            listNumbers[position + j] = 0;
                        }
                    }
                    listNumbers[position] = 0;
                }
            }
            int finalsSum = listNumbers.Sum();
            Console.WriteLine(finalsSum);
        }
    }
}
    