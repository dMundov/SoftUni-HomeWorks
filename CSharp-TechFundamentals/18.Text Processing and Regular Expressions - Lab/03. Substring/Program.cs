using System;
using System.Text;

namespace _03._Substring
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            while (text.Contains(word))
            {
                int firstStep = text.IndexOf(word);
                int step = word.Length;

                for (int i = firstStep; i < text.Length; i++)
                {
                    if (firstStep >= 0)
                    {
                        text = text.Remove(firstStep, step);
                        firstStep = text.IndexOf(word);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"{text}");
        }
    }
}
