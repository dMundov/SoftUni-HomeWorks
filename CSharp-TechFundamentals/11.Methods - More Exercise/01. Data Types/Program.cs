using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();

            if(command=="int")
            {
                int num = int.Parse(Console.ReadLine());
                IntCommand(num);
            }
            if (command == "real")
            {
                double num = double.Parse(Console.ReadLine());
                RealCommand(num);
            }
            if(command=="string")
            {
                string input = Console.ReadLine();
                StringCommand(input);
            }
        }
        static void IntCommand(int num)
        {
            int result = num * 2;
            Console.WriteLine(result);
        }
        static void RealCommand(double num)
        {
            double result = num * 1.5;
            Console.WriteLine($"{result:f2}");
        }
        static void StringCommand(string input)
        {  
            Console.WriteLine($"${input}$");
        }

    }
}
