
/*  first atempt to solve 100/100
   

using system;
using system.linq;

namespace _08._condense_array_to_number
{
    class program
    {
        static void main(string[] args)
        {
            int[] firstarray = console.readline()
                 .split(" ")
                 .select(int.parse)
                 .toarray();

            int count = firstarray.length;
            while (count > 1)
            {
                for (int i = 0; i < count; i++)
                {
                    firstarray[i] = firstarray[i] + firstarray[i + 1];
                    console.write($"{firstarray[i]}{1}", i == count - 2 ? string.empty : " ");
                }

                console.writeline();
                count--;
            }
        }
    }
}
*/
// second metod 100/100
using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();
            int[] condensedArray = new int[firstArray.Length - 1];

            if (firstArray.Length == 1)
            {
                Console.WriteLine(firstArray[0]);
                return;
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < condensedArray.Length - i; j++)
                {
                    condensedArray[j] = firstArray[j] + firstArray[j + 1];
                }
                firstArray = condensedArray;
            }
            Console.WriteLine(condensedArray[0]);
        }
    }
}