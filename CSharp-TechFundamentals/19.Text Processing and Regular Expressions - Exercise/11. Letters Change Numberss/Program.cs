using System;
using System.Linq;

namespace _11._Letters_Change_Numbers
{
    class Program
    {
        static void Main()
        {
            string[] inputData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double Totalsum = 0;
            double currentSum = 0;
            for (int i = 0; i < inputData.Length; i++)
            {
                char firstLetter = inputData[i].ElementAt(0);
                char lastLetter = inputData[i].ElementAt(inputData[i].Length - 1);
                string num = new string(inputData[i].Skip(1).Take(inputData[i].Length - 2).ToArray());
                currentSum = int.Parse(num);
                if (char.IsUpper(firstLetter))
                {
                    currentSum /= (firstLetter - 64);
                }
                else
                {
                    currentSum *= (firstLetter - 96);
                }
                if (char.IsUpper(lastLetter))
                {
                    currentSum -= (lastLetter - 64);
                }
                else
                {
                    currentSum += (lastLetter - 96);
                }
                Totalsum += currentSum;
            }
            Console.WriteLine($"{Totalsum:f2}");
        }
    }
}