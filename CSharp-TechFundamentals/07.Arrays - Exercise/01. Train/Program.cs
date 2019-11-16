using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] wagonsNum = new int[num];
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                wagonsNum[i] = int.Parse(Console.ReadLine());
                sum += wagonsNum[i]; 
            }
            for (int i = 0; i < num; i++)
            {
                Console.Write(wagonsNum[i]+ " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);

            
        }
    }
}
