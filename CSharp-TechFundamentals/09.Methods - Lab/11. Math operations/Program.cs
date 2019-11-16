using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main()
        {
            int fisrtNum = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secNum = int.Parse(Console.ReadLine());
            double result = Calculate(fisrtNum, @operator, secNum);

            Console.WriteLine(result);
        }

        private static double Calculate(int firstNum, string @operator, int secNum)
        {
            double result = 0;

            switch ((@operator))
            {
                case "+":
                    result = firstNum + secNum;
                    return result;
                case "-":
                    result = firstNum - secNum;
                    return result;
                case "*":
                    result = firstNum * secNum;
                    return result;
                case "/":  
                    result = (double)firstNum / secNum;
                    return result;
            }
            return result;
            }
    }
}
