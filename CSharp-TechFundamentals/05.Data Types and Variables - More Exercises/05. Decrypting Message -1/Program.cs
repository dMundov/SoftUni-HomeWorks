using System;
using System.Linq;

namespace _05._Decrypting_Message__1
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int numLines = int.Parse(Console.ReadLine());

            char[] chars = new char[numLines];
            int[] intChars = new int[numLines];
            for (int i = 0; i <chars.Length; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < chars.Length ; i++)
            {
                intChars[i] = chars[i] + key;
                Console.Write((char)intChars[i]);
            }
            Console.WriteLine();
        }
    }
}
