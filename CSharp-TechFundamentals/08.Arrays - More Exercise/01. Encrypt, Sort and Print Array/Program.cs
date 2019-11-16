using System;
using System.Linq;
namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];

            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                char[] letters = Console.ReadLine().ToCharArray();


                for (int j = 0; j < letters.Length; j++)
                {
                    if (letters[j] == 65 || letters[j] == 69
                        || letters[j] == 73
                        || letters[j] == 79
                        || letters[j] == 85
                        || letters[j] == 97
                        || letters[j] == 101
                        || letters[j] == 105
                        || letters[j] == 111
                        || letters[j] == 117)
                    {
                        sum += (int)letters[j] * letters.Length;
                    }
                    else
                    {
                        sum += (int)letters[j] / letters.Length;
                    }
                }
                numbers[i] = sum;
                sum = 0;
            }
            Array.Sort(numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
