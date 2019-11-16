using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (char firstChar = 'a'; firstChar < 'a' + num; firstChar++)
            {
                for (char secondChar = 'a'; secondChar < 'a' + num; secondChar++)
                {
                    for (char thirdChar = 'a'; thirdChar < 'a' + num; thirdChar++)
                    {
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
