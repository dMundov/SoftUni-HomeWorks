/*
7.	Max Sequence of Equal Elements

Write a program that finds the longest sequence of equal elements 
in an array of integers.If several longest sequences exist,
print the leftmost one.

    Examples
Input                   Output
2 1 1 2 3 3 2 2 2 1	    2 2 2
1 1 1 2 3 1 3 3     	1 1 1
4 4 4 4	                4 4 4 4
0 1 1 5 2 2 6 3 3	    1 1
*/

using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int maxSequence = 1;
            int counter = 0;
            int position = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i - 1 >= 0 && numbers[i] == numbers[i - 1])
                {
                    counter++;

                    if (maxSequence < counter)
                    {
                        maxSequence = counter;
                        position = (i - counter) + 1;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            
            for (int i = position; i < position + maxSequence; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06.Max_Sequence_of_Equal_Elements
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//            int longestSeqLength = 1;
//            int longestSeqStart = 0;
//            int currentSeqLength = 1;
//            int currentSeqStart = 0;

//            for (int i = 1; i < array.Length; i++)
//            {
//                if (array[i] == array[i - 1])
//                {
//                    currentSeqLength++;

//                    if (currentSeqLength > longestSeqLength)
//                    {
//                        longestSeqLength = currentSeqLength;
//                        longestSeqStart = currentSeqStart;
//                    }
//                }
//                else
//                {
//                    currentSeqLength = 1;
//                    currentSeqStart = i;
//                }
//            }

//            for (int i = longestSeqStart; i < longestSeqStart + longestSeqLength; i++)
//            {
//                Console.Write(array[i] + " ");
//            }
//        }
//    }
//}