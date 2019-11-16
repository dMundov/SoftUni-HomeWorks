using System;

namespace _07._Repeat_String
{
    class Program
    {
        
        static void Main()
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            StringRepeat(input,count);
        }

         private static void StringRepeat(string input, int count)
         {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += input;
            }
            Console.WriteLine(result);
         }
    }
}
