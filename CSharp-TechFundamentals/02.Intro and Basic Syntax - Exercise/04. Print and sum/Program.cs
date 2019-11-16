using System;


namespace _04._Print_and_sum
{
    class Program
    {
        static void Main()
        {
            int firstNUm = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = firstNUm; i <= secNum; i++)
            {
                sum += i;
                Console.Write(i+" ");                
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
