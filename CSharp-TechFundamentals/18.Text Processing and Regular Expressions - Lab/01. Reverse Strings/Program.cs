using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = "";
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                else
                {
                    for (int i = line.Length - 1; i >= 0; i--)
                    {
                        reversed += line[i];
                    }
                    Console.WriteLine($"{line} = {reversed}");
                }
                reversed = "";
            }
        }
    }
}
