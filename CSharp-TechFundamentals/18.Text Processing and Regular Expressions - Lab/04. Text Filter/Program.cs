using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '*' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (var item in bannedWords)
            {
                text = text.Replace(item, new string('*', item.Length));

            }
            Console.WriteLine(text);
        }
    }
}