using System;
using System.Linq;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {     
            
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine()); 
            int number3 = int.Parse(Console.ReadLine());     
            int[] numbers = { number1, number2, number3,};
            Array.Sort(numbers);
            string num1 = "";
            string num2 = "";
            string num3 = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                 num1 = numbers[0].ToString();
                 num2 = numbers[1].ToString();
                 num3 = numbers[2].ToString();
                break;
            }
            Console.WriteLine($"{num3}\n" +
                $"{num2}\n" +
                $"{num1}");
        }
    }
}
