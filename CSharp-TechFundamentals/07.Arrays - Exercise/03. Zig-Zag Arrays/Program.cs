using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    array2[i] = inputArray[j];
                    array1[i] = inputArray[j + 1];
                }
            }

            for (int i = 0; i < n; i += 2)
            {
                int rotateNum = 0;
                rotateNUm = array2[i];
                array2[i] = array1[i];
                array1[i] = rotateNUm;
            }

            string firstOutput = string.Join(" ", array1);
            string secondOutput = string.Join(" ", array2);

            Console.WriteLine(firstOutput);
            Console.WriteLine(secondOutput);
        }
    }
}