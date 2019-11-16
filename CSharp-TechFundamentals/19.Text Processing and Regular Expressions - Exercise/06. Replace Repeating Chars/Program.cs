using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            
            string outPut = "";
            outPut += input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if(input[i-1]!=input[i])
                {
                    outPut += input[i];
                }
            }
            Console.WriteLine(outPut);
        }
    }
}
