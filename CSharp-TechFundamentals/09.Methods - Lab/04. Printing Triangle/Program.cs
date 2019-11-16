using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            PrintTringle(num);


        }

        static void Printline(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintTringle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Printline(1,i);
            }
            for (int i = num - 1; i >= 1; i--)
            {
                Printline(1, i);
            }        
            
        }
    }
}
