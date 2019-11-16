using System;

namespace _01._Data_Type_Finder
{
    class Program
    {

        static void Main()
        {       
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                bool isBool = bool.TryParse(input, out bool boolean);
                bool isInt = int.TryParse(input, out int integer);
                bool isChar = char.TryParse(input, out char character);
                bool isFloat = float.TryParse(input, out float floating);
                if (isBool)
                {
                    Console.WriteLine($"{input} is boolean type");

                }
                else if (isInt)
                {
                    Console.WriteLine($"{integer} is integer type");

                }
                else if (isChar)
                {
                    Console.WriteLine($"{character} is character type");

                }
                else if (isFloat)
                {
                    Console.WriteLine($"{input} is floating point type");

                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
  